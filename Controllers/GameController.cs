using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebGame.Models.GameViewModels;
using WebGame.Models.WebGame;
using WebGame.ViewModel;

namespace WebGame.Controllers
{
    public class GameController : Controller
    {
        private readonly webgameContext _context;

        public GameController(webgameContext context)
        {
            _context = context;
        }

        [HttpGet("Game/MainGameRazor/{error}/{player1Id}/{player2Id}/{worldId}/{accountCheck}")]
        public async Task<IActionResult> MainGameRazor(int accountCheck, int player1Id, int player2Id, int? worldId, int? error)
        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return RedirectToAction(nameof(SelectGame));
            }

            var world = _context.World
                .FirstOrDefault(m => m.WorldId == worldId);

            // Security
            if (world.Player1IdAcc != (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && world.Player2IdAcc != (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))))
            {
                return RedirectToAction("SelectGame", "Game");
            }
            if (world.GameFinished == true)
            {
                return RedirectToAction("SelectGame", "Game");
            }

            if (error == 1)
            {
                ViewBag.Error = "You don't have enough money to upgrade this tower!";
            }

            ViewBag.WorldId = worldId;

            ViewBag.Player1Id = player1Id;
            ViewBag.Player2Id = player2Id;
            if (world.Player1IdAcc == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))))
            {
                var enemyName = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.Player2IdAcc);
                // If name is too long
                if (enemyName.AccountName.Length > 5)
                {
                    ViewBag.EnemyName = enemyName.AccountName.Substring(0, 5) + "...";
                }
                else
                {
                    ViewBag.EnemyName = enemyName.AccountName;
                }
                ViewBag.EnemyId = enemyName.AccountId;
                var yourName = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.Player1IdAcc);

                // If name is too long
                if (yourName.AccountName.Length > 5)
                {
                    ViewBag.YourName = yourName.AccountName.Substring(0, 5) + "...";
                }
                else
                {
                    ViewBag.YourName = yourName.AccountName;
                }
                ViewBag.YourId = yourName.AccountId;
            }
            else
            {
                var enemyName = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.Player1IdAcc);
                if (enemyName.AccountName.Length > 5)
                {
                    ViewBag.EnemyName = enemyName.AccountName.Substring(0, 5) + "...";
                }
                else
                {
                    ViewBag.EnemyName = enemyName.AccountName;
                }
                ViewBag.EnemyId = enemyName.AccountId;

                var yourName = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.Player2IdAcc);
                if (yourName.AccountName.Length > 5)
                {
                    ViewBag.YourName = yourName.AccountName.Substring(0, 5) + "...";
                }
                else
                {
                    ViewBag.YourName = yourName.AccountName;
                }
                ViewBag.YourId = yourName.AccountId;
            }

            if (world.GameFinished == true)
            {
                var PlayeraccountNameWin = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.WinnerAccountId);

                ViewBag.Winner = "Player " + PlayeraccountNameWin.AccountName + " won the game!";
                ViewBag.IsWinner = true;
            }

            var playerIdWhoClicks = (from d in _context.Player where d.WorldId == worldId && d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) select d.PlayerId).FirstOrDefault();

            ViewBag.PlayerIdWhoClicks = playerIdWhoClicks;

            if (playerIdWhoClicks == player1Id) // For SignalR function Dynamic OverallStats update
            {
                ViewBag.EnemyPlayerId = player2Id;
            }
            else
            {
                ViewBag.EnemyPlayerId = player1Id;
            }

            var findPlayerGold = (from d in _context.Player where d.PlayerId == playerIdWhoClicks && d.WorldId == worldId select d.Gold).FirstOrDefault();

            ViewBag.FindPlayerGold = findPlayerGold;

            var loggedInPlayerTowers = (from d in _context.Tower where d.Owner == playerIdWhoClicks && d.WorldId == worldId select d).ToList();

            int peopleGrowingPlusPeopleAlive = 0;
            int peopleGrowing = 0;
            int peopleNow = 0;
            int goldForTowers = 0;
            foreach (var tower in loggedInPlayerTowers)
            {
                float? peopleGrowingPercentage = (100 + tower.TowerLvl) / 100f;
                float? peopleGrown = peopleGrowingPercentage * tower.Attack;
                peopleNow += tower.Attack;
                peopleGrowing += Convert.ToInt32(peopleGrown) - tower.Attack;
                peopleGrowingPlusPeopleAlive += Convert.ToInt32(peopleGrown);
                goldForTowers += 10;
            }
            ViewBag.GoldForTowers = goldForTowers;
            ViewBag.PeopleNow = peopleNow;
            ViewBag.PeopleGrowing = peopleGrowing;
            ViewBag.PeopleGrowingSum = peopleGrowingPlusPeopleAlive;

            ViewBag.WorldId = worldId;

            var playerIds = (from d in _context.Player where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) select d.PlayerId).ToList();

            // GET LOGGED IN ACCOUNT PLAYERID
            if (world.Player1Ready == true ^ world.Player2Ready == true) // IF ONLY ONE OF THEM IS READY
            {
                if (playerIds.Contains(player1Id) && world.Player1Id == player1Id && world.Player1Ready == true)
                {
                    ViewBag.You = "YOU ARE READY";
                    ViewBag.Enemy = "ENEMY IS NOT READY";
                }
                else if (!playerIds.Contains(player1Id) && world.Player1Id == player1Id && world.Player1Ready == true)
                {
                    ViewBag.You = "YOU ARE NOT READY";
                    ViewBag.Enemy = "ENEMY IS READY";
                }
                else if (playerIds.Contains(player2Id) && world.Player2Id == player2Id && world.Player2Ready == true)
                {
                    ViewBag.You = "YOU ARE READY";
                    ViewBag.Enemy = "ENEMY IS NOT READY";
                }
                else if (!playerIds.Contains(player2Id) && world.Player2Id == player2Id && world.Player2Ready == true)
                {
                    ViewBag.You = "YOU ARE NOT READY";
                    ViewBag.Enemy = "ENEMY IS READY";
                }
            }
            else if (world.Player1Ready == false && world.Player2Ready == false) // CHECK IF BOTH ARE NOT READY
            {
                ViewBag.You = "YOU ARE NOT READY";
                ViewBag.Enemy = "ENEMY IS NOT READY";
            }
            else if (world.Player1Ready == true && world.Player2Ready == true) // CHECK IF BOTH ARE READY
            {
                world.Player1Ready = false;
                world.Player2Ready = false;
                _context.Update(world);
                _context.SaveChanges();
            }

            var towers = await (from ep in _context.Tower
                                join e in _context.World on ep.WorldId equals e.WorldId
                                //where worldTowers.Contains(ep.Owner)
                                where e.WorldId == worldId
                                select new TowerViewModel
                                {
                                    Id = ep.TowerId,
                                    Owner = ep.Owner,
                                    TowerId = ep.TowerId,
                                    Attack = ep.Attack,
                                    Defence = ep.Defence,
                                    WorldId = e.WorldId,
                                    Player1Id = e.Player1Id,
                                    Player2Id = e.Player2Id,
                                    Player1Ready = e.Player1Ready,
                                    Player2Ready = e.Player2Ready,
                                    TowerLvl = ep.TowerLvl,
                                    TowerName = ep.TowerName
                                }).ToListAsync();

            ViewBag.Towers = towers;

            return View(towers);
        }

        [HttpGet("Game/Profile/{accountId}")]
        public async Task<IActionResult> Profile(int accountId) // SAFE
        {
            var profile = (from d in _context.Playeraccount where d.AccountId == accountId select d).FirstOrDefault();

            ViewBag.Name = profile.AccountName;
            ViewBag.Wins = profile.Wins;
            ViewBag.Losts = profile.Losts;

            if (profile.Wins > 0 && profile.Losts < 1)
            {
                ViewBag.WinRate = profile.Wins * 100;
            }
            else
            {
                ViewBag.WinRate = (float)System.Math.Round(((float)profile.Wins / (profile.Wins + profile.Losts)) * 100, 2); // only 2 numbers after comma
            }
            return View();
        }
        //public async Task<IActionResult> UpgradeTower(int id, TowerViewModel towerViewModel) // SAFE tänu playerId kontrollile?

        //Game/UpgradeTower/12?accountId=4&amp;owner=2&amp;player1Id=1&amp;player2Id=2&amp;worldId=1"
        [HttpGet("Game/UpgradeTower/{id}/{accountId}/{owner}/{player1Id}/{player2Id}/{worldId}")]
        public async Task<IActionResult> UpgradeTower(int id, int accountId, int owner, int player1Id, int player2Id, int worldId) // SAFE tänu playerId kontrollile?

        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return RedirectToAction(nameof(SelectGame));
            }

            var upgradingTower = await _context.Tower.FindAsync(id);

            var player = (from d in _context.Player
                          where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && d.WorldId == worldId && d.PlayerId == owner

                          select d).FirstOrDefault();

            player.Gold -= (upgradingTower.TowerLvl + 1) * 100;

            if (player.Gold < 0)
            {
                // return RedirectToAction("MainGame", new { error = 1, Player1Id = player1Id, Player2Id = player2Id, WorldId = worldId, accountId = (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) });
                return Redirect("http://siim.cc/Game/MainGameRazor/1/" + player1Id + "/" + player2Id + "/" + worldId + "/" + accountId);

            }
            if (player.Gold >= 0)
            {
                upgradingTower.TowerLvl += 1;
                upgradingTower.Defence = upgradingTower.TowerLvl * 5;

                _context.Update(player); // Võib ka kõrgemale tõsta? Võibolla tõstes läheb kood koledamaks
                _context.Update(upgradingTower);

                await _context.SaveChangesAsync();
            }
            return Redirect("http://siim.cc/Game/MainGameRazor/0/" + player1Id + "/" + player2Id + "/" + worldId + "/" + accountId);

        }

        [HttpGet("Game/CancelArmyMovement/{worldId}/{PlayerIdWhoClicks}/{player1Id}/{player2Id}")]
        public async Task<IActionResult> CancelArmyMovement(int PlayerIdWhoClicks, int worldId, int player1Id, int player2Id, TowerViewModel towerViewModel) // SAFE
        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return RedirectToAction(nameof(SelectGame));
            }

            ViewBag.Player1Id = player1Id;
            ViewBag.Player2Id = player2Id;

            var armyMovings = (from d in _context.AttDef where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && d.WorldId == worldId && d.ReturnBase == false select d).ToListAsync();

            ViewBag.PlayerIdWhoClicks = PlayerIdWhoClicks;
            ViewBag.WorldId = worldId;

            if (armyMovings.Result.Count == 0)
            {
                ViewBag.Empty = true;
                return View();

            }

            List<int> towerIds = new List<int>();

            foreach (var moving in armyMovings.Result)
            {
                towerIds.Add(moving.TargetTowerId);
            }
            List<string> towerNames = new List<string>();

            for (int i = 0; i < towerIds.Count; i++)
            {
                var towerName = (from d in _context.Tower where d.TowerId == Convert.ToInt32(towerIds[i]) select d.TowerName).FirstOrDefault();
                towerNames.Add(towerName);
            }

            ViewBag.TowerNames = towerNames;

            return View(await armyMovings);
        }

        public async Task<IActionResult> CancelArmyMovement_(int accountCheck, int id, int worldId, int owner, int player1Id, int player2Id, TowerViewModel towerViewModel, AttDef attdef) // VIST SAFE
        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return RedirectToAction(nameof(SelectGame));
            }
            if (accountCheck != (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))))
            {
                return RedirectToAction("CancelArmyMovement", new
                {
                    worldId = worldId,
                    accountId = (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)))
                });
            }

            var mainBaseLocation = (from d in _context.Tower
                                    where (d.TowerName == "MainBase1" || d.TowerName == "MainBase2") && d.Owner == owner && d.WorldId == worldId
                                    select d).FirstOrDefault();

            var movement = await _context.AttDef.FindAsync(id);

            // SEND ARMY BACK TO MAIN BASE
            attdef.Id = 0; // AutoIncrement
            attdef.WorldId = worldId;
            attdef.AttackerPlayerId = owner;
            if (mainBaseLocation == null)
            {
                attdef.TargetTowerId = movement.TargetTowerId;
            }
            else
            {
                attdef.TargetTowerId = mainBaseLocation.TowerId;
            }
            attdef.Amount += movement.Amount;
            attdef.RoundsToArrive = 10; //Current round + (the value from tower distance to other tower)
            attdef.AccountId = (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)));
            attdef.ReturnBase = true;
            _context.Add(attdef);
            _context.AttDef.Remove(movement); // kas on vaja AttDef osa?
            await _context.SaveChangesAsync();
            return RedirectToAction("CancelArmyMovement", new
            {
                worldId = worldId,
                PlayerIdWhoClicks = owner,
                player1Id = player1Id,
                player2Id = player2Id
            });
        }

        public async Task<IActionResult> NewGame(World world, Player player) // 100% SAFE
        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return RedirectToAction(nameof(SelectGame));
            }

            var checkWorld = (from d in _context.World where d.Player1Id > 0 && d.Player2Id <= 0 select d.WorldId).FirstOrDefault();

            var worldToEdit = _context.World.FirstOrDefault(m => m.WorldId == checkWorld);

            if (checkWorld == 0 || worldToEdit.Player1IdAcc != (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))))
            {
                // JOIN A NEW GAME IF WORLD HAS BEEN ALREADY MADE (CREATE PlayerId & Towers 
                if (checkWorld != null && checkWorld != 0)
                {
                    var findEmptyWorld = (from d in _context.World where d.Player2Id == null || d.Player2Id == 0 select d.WorldId).First();

                    player.PlayerId = 0; // AutoIncrement
                    player.AccountId = (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)));
                    player.WorldId = findEmptyWorld; // UUS
                    player.Gold = 1000;
                    _context.Add(player);
                    await _context.SaveChangesAsync();

                    var maxWPlayerId = _context.Player.Max(x => x.PlayerId); // Find max PlayerId 

                    worldToEdit.Player2Id = player.PlayerId;
                    worldToEdit.GameStarted = true;
                    worldToEdit.Player2Ready = false;
                    worldToEdit.Player2IdAcc = (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)));
                    _context.Update(worldToEdit);
                    await _context.SaveChangesAsync();

                    var newMaxWorldId = _context.World.Max(x => x.WorldId); // Find max WorldId 
                    var newTowersWorld = _context.World
                        .FirstOrDefault(m => m.WorldId == newMaxWorldId);

                    string[] baseName = {
                        "Hotel",
                        "India",
                        "Juliett",
                        "Kilo",
                        "Lima",
                        "Mike",
                        "November",
                        "MainBase2"
                    };
                    int[] xCord = {
                        4,
                        5,
                        5,
                        5,
                        6,
                        6,
                        6,
                        7
                    };
                    int[] yCord = {
                        1,
                        0,
                        1,
                        2,
                        0,
                        1,
                        2,
                        1
                    };

                    var tower_ = new List<Tower>();
                    for (int i = 0; i < 8; i++) // Make 8 Towers           
                    {
                        if (i == 7)
                        {
                            tower_.Add(new Tower
                            {
                                TowerId = 0,
                                WorldId = newMaxWorldId,
                                Owner = player.PlayerId,
                                TowerName = baseName[i],
                                Attack = 1000,
                                Defence = 10,
                                LocationX = xCord[i],
                                LocationY = yCord[i],
                                TowerLvl = 10
                            });
                            continue;
                        }
                        tower_.Add(new Tower
                        {
                            TowerId = 0,
                            WorldId = newMaxWorldId,
                            Owner = player.PlayerId,
                            TowerName = baseName[i],
                            Attack = 100,
                            Defence = 5,
                            LocationX = xCord[i],
                            LocationY = yCord[i],
                            TowerLvl = 1
                        });
                    }
                    _context.AddRange(tower_);
                    await _context.SaveChangesAsync();
                }
                // CREATE NEW WORLD, PlayerId & Towers
                else
                {
                    world.WorldId = 0; // AutoIncrement
                    world.Player1Id = 0;
                    world.Player2Id = 0;
                    world.GameStarted = false;
                    world.GameFinished = false;
                    world.WinnerAccountId = 0;
                    world.Player1Ready = false;
                    world.Player2Ready = false;
                    world.Player1IdAcc = (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)));

                    _context.Add(world);
                    await _context.SaveChangesAsync();

                    player.PlayerId = 0; // AutoIncrement
                    player.AccountId = (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)));
                    player.WorldId = world.WorldId;
                    player.Gold = 1000;

                    _context.Add(player);
                    await _context.SaveChangesAsync();

                    world.Player1Id = player.PlayerId;

                    _context.Update(world);
                    await _context.SaveChangesAsync();

                    string[] baseName = {
                        "MainBase1",
                        "Alpha",
                        "Beta",
                        "Charlie",
                        "Delta",
                        "Echo",
                        "Foxtrot",
                        "Golf"
                    };
                    int[] xCord = {
                        0,
                        1,
                        1,
                        1,
                        2,
                        2,
                        2,
                        3
                    };
                    int[] yCord = {
                        1,
                        0,
                        1,
                        2,
                        0,
                        1,
                        2,
                        1
                    };

                    var tower_ = new List<Tower>();
                    for (int i = 0; i < 8; i++) // Make 8 Towers           
                    {
                        if (i == 0)
                        {
                            tower_.Add(new Tower
                            {
                                TowerId = 0,
                                WorldId = world.WorldId,
                                Owner = player.PlayerId,
                                TowerName = baseName[i],
                                Attack = 1000,
                                Defence = 10,
                                LocationX = xCord[i],
                                LocationY = yCord[i],
                                TowerLvl = 10
                            });
                            continue;
                        }
                        tower_.Add(new Tower
                        {
                            TowerId = 0,
                            WorldId = world.WorldId,
                            Owner = player.PlayerId,
                            TowerName = baseName[i],
                            Attack = 100,
                            Defence = 5,
                            LocationX = xCord[i],
                            LocationY = yCord[i],
                            TowerLvl = 1
                        });
                    }
                    _context.AddRange(tower_);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                TempData["Queue"] = "You are already in queue";
            }
            return RedirectToAction("SelectGame", "Game");
        }

        [HttpGet]
        public async Task<IActionResult> MainGame(int accountCheck, int player1Id, int player2Id, int? worldId, int? error)
        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return RedirectToAction(nameof(SelectGame));
            }

            var world = _context.World
                .FirstOrDefault(m => m.WorldId == worldId);

            // Security
            if (world.Player1IdAcc != (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && world.Player2IdAcc != (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))))
            {
                return RedirectToAction("SelectGame", "Game");
            }
            if (world.GameFinished == true)
            {
                return RedirectToAction("SelectGame", "Game");
            }
            if (error == 1)
            {
                ViewBag.Error = "You don't have enough money to upgrade this tower!";
            }

            ViewBag.Player1Id = player1Id;
            ViewBag.Player2Id = player2Id;
            if (world.Player1IdAcc == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))))
            {
                var enemyName = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.Player2IdAcc);
                ViewBag.EnemyName = enemyName.AccountName;
                ViewBag.EnemyId = enemyName.AccountId;
                var yourName = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.Player1IdAcc);
                ViewBag.YourName = yourName.AccountName;
                ViewBag.YourId = yourName.AccountId;
            }
            else
            {
                var enemyName = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.Player1IdAcc);
                ViewBag.EnemyName = enemyName.AccountName;
                ViewBag.EnemyId = enemyName.AccountId;
                var yourName = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.Player2IdAcc);
                ViewBag.YourName = yourName.AccountName;
                ViewBag.YourId = yourName.AccountId;
            }

            if (world.GameFinished == true)
            {
                var PlayeraccountNameWin = _context.Playeraccount.FirstOrDefault(m => m.AccountId == world.WinnerAccountId);

                ViewBag.Winner = "Player " + PlayeraccountNameWin.AccountName + " won the game!";
                ViewBag.IsWinner = true;
            }
            var playerIdWhoClicks = (from d in _context.Player where d.WorldId == worldId && d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) select d.PlayerId).FirstOrDefault();

            ViewBag.PlayerIdWhoClicks = playerIdWhoClicks;

            var findPlayerGold = (from d in _context.Player where d.PlayerId == playerIdWhoClicks && d.WorldId == worldId select d.Gold).FirstOrDefault();

            ViewBag.FindPlayerGold = findPlayerGold;

            var loggedInPlayerTowers = (from d in _context.Tower where d.Owner == playerIdWhoClicks && d.WorldId == worldId select d).ToList();

            int peopleGrowingPlusPeopleAlive = 0;
            int peopleGrowing = 0;
            int peopleNow = 0;
            int goldForTowers = 0;
            foreach (var tower in loggedInPlayerTowers)
            {
                float? peopleGrowingPercentage = (100 + tower.TowerLvl) / 100f;
                float? peopleGrown = peopleGrowingPercentage * tower.Attack;
                peopleNow += tower.Attack;
                peopleGrowing += Convert.ToInt32(peopleGrown) - tower.Attack;
                peopleGrowingPlusPeopleAlive += Convert.ToInt32(peopleGrown);
                goldForTowers += 10;
            }
            ViewBag.GoldForTowers = goldForTowers;
            ViewBag.PeopleNow = peopleNow;
            ViewBag.PeopleGrowing = peopleGrowing;
            ViewBag.PeopleGrowingSum = peopleGrowingPlusPeopleAlive;

            ViewBag.WorldId = worldId;

            var playerIds = (from d in _context.Player where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) select d.PlayerId).ToList();

            // GET LOGGED IN ACCOUNT PLAYERID
            if (world.Player1Ready == true ^ world.Player2Ready == true) // IF ONLY ONE OF THEM IS READY
            {
                if (playerIds.Contains(player1Id) && world.Player1Id == player1Id && world.Player1Ready == true)
                {
                    ViewBag.You = "YOU ARE READY";
                    ViewBag.Enemy = "ENEMY IS NOT READY";
                }
                else if (!playerIds.Contains(player1Id) && world.Player1Id == player1Id && world.Player1Ready == true)
                {
                    ViewBag.You = "YOU ARE NOT READY";
                    ViewBag.Enemy = "ENEMY IS READY";
                }
                else if (playerIds.Contains(player2Id) && world.Player2Id == player2Id && world.Player2Ready == true)
                {
                    ViewBag.You = "YOU ARE READY";
                    ViewBag.Enemy = "ENEMY IS NOT READY";
                }
                else if (!playerIds.Contains(player2Id) && world.Player2Id == player2Id && world.Player2Ready == true)
                {
                    ViewBag.You = "YOU ARE NOT READY";
                    ViewBag.Enemy = "ENEMY IS READY";
                }
            }
            else if (world.Player1Ready == false && world.Player2Ready == false) // CHECK IF BOTH ARE NOT READY
            {
                ViewBag.You = "YOU ARE NOT READY";
                ViewBag.Enemy = "ENEMY IS NOT READY";
            }
            else if (world.Player1Ready == true && world.Player2Ready == true) // CHECK IF BOTH ARE READY
            {
                world.Player1Ready = false;
                world.Player2Ready = false;
                _context.Update(world);
                _context.SaveChanges();
            }

            var towers = await (from ep in _context.Tower
                                join e in _context.World on ep.WorldId equals e.WorldId
                                where e.WorldId == worldId
                                select new TowerViewModel
                                {
                                    Id = ep.TowerId,
                                    Owner = ep.Owner,
                                    TowerId = ep.TowerId,
                                    Attack = ep.Attack,
                                    Defence = ep.Defence,
                                    WorldId = e.WorldId,
                                    Player1Id = e.Player1Id,
                                    Player2Id = e.Player2Id,
                                    Player1Ready = e.Player1Ready,
                                    Player2Ready = e.Player2Ready,
                                    TowerLvl = ep.TowerLvl,
                                    TowerName = ep.TowerName
                                }).ToListAsync();
            return View(towers);
        }

        [HttpGet("Game/PlayerReady/{worldId}")]
        public IActionResult PlayerReady(int worldId, TowerViewModel towerViewModel) // SAFE
        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return RedirectToAction(nameof(SelectGame));
            }

            var world = _context.World
                .FirstOrDefault(m => m.WorldId == worldId);

            if (world == null)
            {
                return NotFound();
            }
            var player = _context.Player
                .FirstOrDefault(m => m.WorldId == worldId && m.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))));

            if (world.Player1Id == player.PlayerId && world.WorldId == worldId)
            {
                world.Player1Ready = true;
            }
            if (world.Player2Id == player.PlayerId && world.WorldId == worldId)
            {
                world.Player2Ready = true;
            }

            List<Tower> towerList = new List<Tower>();
            towerList = (from product in _context.Tower where product.WorldId == worldId select product).ToList();

            if (world.Player1Ready == true && world.Player2Ready == true)
            {
                var player1Gold = _context.Player
                    .FirstOrDefault(m => m.WorldId == worldId && m.PlayerId == world.Player1Id);

                var player2Gold = _context.Player
                    .FirstOrDefault(m => m.WorldId == worldId && m.PlayerId == world.Player2Id);

                foreach (var tower in towerList)
                {
                    if (tower.Owner == world.Player1Id)
                    {
                        player1Gold.Gold += 10;
                    }
                    if (tower.Owner == world.Player2Id)
                    {
                        player2Gold.Gold += 10;
                    }
                }
                _context.Update(player1Gold);
                _context.Update(player2Gold);

                // People born
                foreach (var tower in towerList)
                {
                    float? peopleGrowingPercentage = (100 + tower.TowerLvl) / 100f; // 5 percentage more poeple
                    float? peopleGrowed = peopleGrowingPercentage * tower.Attack;
                    tower.Attack = Convert.ToInt32(peopleGrowed);
                }
                _context.UpdateRange(towerList);

                List<AttDef> moveChanging = new List<AttDef>(); // Army goes closer
                moveChanging = (from m in _context.AttDef where m.WorldId == worldId select m).ToList();

                if (moveChanging.Count > 0) // if there is any army moving
                {
                    for (int i = 0; i < moveChanging.Count; i++)
                    {
                        moveChanging[i].RoundsToArrive -= 1;
                    }
                    _context.UpdateRange(moveChanging);
                }

                List<AttDef> armyToTower = new List<AttDef>(); // do army action
                armyToTower = (from m in _context.AttDef where m.WorldId == worldId && m.RoundsToArrive <= 0 select m).ToList();

                if (armyToTower.Count > 0)
                {
                    Tower[] whereArmyGoes = new Tower[armyToTower.Count];
                    List<int> attackersDestination = new List<int>(); // Store enemy's army destination

                    for (int i = 0; i < armyToTower.Count; i++) // Friendly army must arrive first
                    {
                        whereArmyGoes[i] = (from d in _context.Tower where d.TowerId == armyToTower[i].TargetTowerId select d).First();

                        if (whereArmyGoes[i].Owner == armyToTower[i].AttackerPlayerId) // If army goes to friendly's base
                            whereArmyGoes[i].Attack += armyToTower[i].Amount;

                        else // If army goes enemy's base OR it's neutral base
                            attackersDestination.Add(i);
                    }

                    bool destroyedTower = false;
                    for (int i = 0; i < attackersDestination.Count; i++)
                    {
                        // && check if it's still the last attacker tower. If not, then enemy attacks it.
                        if (destroyedTower == true && whereArmyGoes[attackersDestination[i]].Owner == armyToTower[i].AttackerPlayerId)
                        {
                            whereArmyGoes[attackersDestination[i]].Attack += armyToTower[attackersDestination[i]].Amount;
                        }
                        else
                        {
                            // Calculate also the tower strength (defence)
                            float prepare = (100 - (whereArmyGoes[attackersDestination[i]].Defence)) / 100f;

                            float strength = armyToTower[attackersDestination[i]].Amount * prepare;
                            whereArmyGoes[attackersDestination[i]].Attack -= Convert.ToInt32(strength);
                        }
                        if (whereArmyGoes[attackersDestination[i]].Attack < 0)
                        {
                            whereArmyGoes[attackersDestination[i]].Owner = armyToTower[i].AttackerPlayerId;
                            whereArmyGoes[attackersDestination[i]].Attack *= -1;
                            destroyedTower = true;
                        }
                        if (whereArmyGoes[attackersDestination[i]].Attack == 0)
                        {
                            whereArmyGoes[attackersDestination[i]].Owner = 0;
                        }
                    }
                    _context.UpdateRange(whereArmyGoes); // võibolla peab olema see LOOPIS
                }
                _context.AttDef.RemoveRange(_context.AttDef.Where(x => x.WorldId == worldId && x.RoundsToArrive <= 0));

                world.Player1Ready = false;
                world.Player2Ready = false;

                _context.Update(world);

                // Check if a player won the game
                var checkIfNoOwner1 = 0;
                checkIfNoOwner1 = towerList.Count(p => p.Owner == world.Player1Id);

                if (checkIfNoOwner1 <= 0 || checkIfNoOwner1 >= 16)
                {
                    if (checkIfNoOwner1 == 0)
                    {
                        var PlayeraccountWin = _context.Playeraccount
                            .FirstOrDefault(m => m.AccountId == world.Player2IdAcc);
                        PlayeraccountWin.Wins += 1;

                        var PlayeraccountLost = _context.Playeraccount
                            .FirstOrDefault(m => m.AccountId == world.Player1IdAcc);
                        PlayeraccountLost.Losts += 1;

                        world.WinnerAccountId = world.Player2IdAcc;
                        world.GameFinished = true;
                    }
                    else if (checkIfNoOwner1 == 16)
                    {
                        var PlayeraccountWin = _context.Playeraccount
                            .FirstOrDefault(m => m.AccountId == world.Player1IdAcc);
                        PlayeraccountWin.Wins += 1;

                        var PlayeraccountLost = _context.Playeraccount
                            .FirstOrDefault(m => m.AccountId == world.Player2IdAcc);
                        PlayeraccountLost.Losts += 1;

                        world.WinnerAccountId = world.Player1IdAcc;
                        world.GameFinished = true;
                    }
                    // Make space in database after game has ended
                    _context.AttDef.RemoveRange(_context.AttDef.Where(x => x.WorldId == worldId));
                    _context.Tower.RemoveRange(_context.Tower.Where(x => x.WorldId == worldId));
                    _context.Player.RemoveRange(_context.Player.Where(x => x.WorldId == worldId));
                }
            }
            _context.Update(world);
            _context.SaveChanges();

            return Redirect("http://siim.cc/Game/MainGameRazor/0/" + world.Player1Id + "/" + world.Player2Id + "/" + worldId + "/" + (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))));

        }

        [HttpPost("Game/CreateArmyMission/{worldId}/{Owner}/{player1Id}/{player2Id}/{SelectedTower}/{playerIdWhoClicks}")]
        //[HttpPost("Game/CreateArmyMission/{worldId}/{Owner}/{player1Id}/{player2Id}/{SelectedTower}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateArmyMission(int SelectedWorldId, int Owner, bool connected, int SelectedTowerId, EditViewModel editViewModel, AttDef attdef, Tower tower, World world, TowerViewModel towerViewModel, int worldId, int player1Id, int player2Id, int SelectedTower) // EI OLE SAFE?
        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return RedirectToAction(nameof(SelectGame));
            }
            try
            {
                int attackSum = 0;
                var idWhereArmyGoes = (from d in _context.Tower where d.TowerId == SelectedTowerId select d).First();

                if (connected == true) // All the armies go together
                {
                    List<int> towersWhatAttackArrivingTime = new List<int>();

                    for (int i = 0; i < editViewModel.TowerAttack.Count; i++) // UPDATE ALL CHANGED FORMS
                    {
                        if (editViewModel.TowerAttack[i] <= 0) continue; // If zero army men from tower

                        tower = _context.Tower.First(m => m.TowerId == editViewModel.TowerId[i]); // Tower where attackers come from

                        // If not enough army men from tower
                        if (tower.Attack - editViewModel.TowerAttack[i] < 1)
                        {
                            var playerId = (from d in _context.Player where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && d.PlayerId == Owner select d.PlayerId).FirstOrDefault();

                            List<Tower> towerList2 = new List<Tower>();

                            if (playerId == Owner) // The clicked tower is his own
                            {
                                towerList2 = (from product in _context.Tower
                                              where product.Owner == Owner && product.WorldId == worldId // Logged in account ID
                                              select product).ToList();
                            }
                            else
                            {
                                towerList2 = (from product in _context.Tower
                                              where product.Owner != Owner && product.WorldId == worldId // Logged in account ID
                                              select product).ToList();
                            }
                            ViewBag.ListofTower = towerList2;
                            ViewBag.Owner = Owner;
                            ViewBag.SelectedTower = SelectedTower;
                            ViewBag.WorldId = worldId;
                            ViewBag.Error = "You must let atleast one man behind to the tower where you attack from";
                            ViewBag.Arrival = editViewModel.arrivingTime;

                            if (playerId == Owner) // The clicked tower is his own
                            {
                                List<int> LoggedInPlayerTowers = new List<int>();
                                foreach (var item in towerList2) // Add TowerId-s to another List, so it's faster loading
                                {
                                    LoggedInPlayerTowers.Add(item.TowerId);
                                }
                                ViewBag.loggedInPlayerTowers = LoggedInPlayerTowers;
                            }
                            return View(editViewModel);
                        }

                        tower.Attack -= editViewModel.TowerAttack[i];

                        _context.Update(tower);

                        attackSum += editViewModel.TowerAttack[i];

                        towersWhatAttackArrivingTime.Add(editViewModel.arrivingTime[i]);
                        //towersWhatAttackArrivingTime[i] = editViewModel.arrivingTime[i]
                    }
                    int highestArrivalTime = towersWhatAttackArrivingTime.Max(); // Find the longest army moving time

                    var whoAttacks = (from d in _context.Player where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && d.WorldId == SelectedWorldId select d.PlayerId).First();

                    attdef.Id = 0; // AutoIncrement
                    attdef.WorldId = SelectedWorldId;
                    attdef.AttackerPlayerId = whoAttacks;
                    attdef.TargetTowerId = SelectedTowerId;
                    attdef.Amount = attackSum;
                    attdef.RoundsToArrive = highestArrivalTime; //Current round + (the value from tower distance to other tower)
                    attdef.AccountId = (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)));

                    _context.Add(attdef);
                    await _context.SaveChangesAsync();
                }
                if (connected == false) // Army trip is separated from other's 
                {
                    var playerId3 = (from d in _context.Player where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && d.WorldId == SelectedWorldId select d.PlayerId).First();

                    var attdefs = new List<AttDef>();
                    for (int i = 0; i < editViewModel.TowerAttack.Count; i++)
                    {
                        if (editViewModel.TowerAttack[i] <= 0) continue;

                        tower = _context.Tower.First(m => m.TowerId == editViewModel.TowerId[i]);

                        if (tower.Attack - editViewModel.TowerAttack[i] < 1)
                        {
                            var playerId = (from d in _context.Player where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && d.PlayerId == Owner select d.PlayerId).FirstOrDefault();

                            List<Tower> towerList2 = new List<Tower>();

                            if (playerId == Owner) // The clicked tower is his own
                            {
                                towerList2 = (from product in _context.Tower
                                              where product.Owner == Owner && product.WorldId == worldId // Logged in account ID
                                              select product).ToList();
                            }
                            else
                            {
                                towerList2 = (from product in _context.Tower
                                              where product.Owner != Owner && product.WorldId == worldId // Logged in account ID
                                              select product).ToList();
                            }
                            ViewBag.ListofTower = towerList2;
                            ViewBag.Owner = Owner;
                            ViewBag.SelectedTower = SelectedTower;
                            ViewBag.WorldId = worldId;
                            ViewBag.Error = "You must let atleast one man behind to the tower where you attack from";
                            ViewBag.Arrival = editViewModel.arrivingTime;

                            if (playerId == Owner) // The clicked tower is his own
                            {
                                List<int> LoggedInPlayerTowers = new List<int>();
                                foreach (var item in towerList2) // Add TowerId-s to another List, so it's faster loading
                                {
                                    LoggedInPlayerTowers.Add(item.TowerId);
                                }
                                ViewBag.loggedInPlayerTowers = LoggedInPlayerTowers;
                            }
                            return View(editViewModel);
                        }
                        tower.Attack -= editViewModel.TowerAttack[i];
                        _context.Update(tower);

                        attackSum = editViewModel.TowerAttack[i];

                        int arrival = editViewModel.arrivingTime[i];

                        attdefs.Add(new AttDef
                        {
                            Id = 0,
                            WorldId = SelectedWorldId,
                            AttackerPlayerId = playerId3,
                            TargetTowerId = SelectedTowerId,
                            Amount = attackSum,
                            RoundsToArrive = arrival,
                            AccountId = (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)))
                        });
                    }
                    _context.AddRange(attdefs);
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TowerExists(editViewModel.Tower.TowerId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Redirect("http://siim.cc/Game/MainGameRazor/0/" + player1Id + "/" + player2Id + "/" + worldId + "/" + (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))));

        }

        [HttpGet("Game/CreateArmyMission/{worldId}/{Owner}/{player1Id}/{player2Id}/{SelectedTower}/{playerIdWhoClicks}")]

        //[HttpGet("Game/CreateArmyMission/{worldId}/{Owner}/{player1Id}/{player2Id}/{SelectedTower}")]
        public async Task<IActionResult> CreateArmyMission(int playerIdWhoClicks, int? worldId, int SelectedTower, int? Owner, int player1Id, int player2Id) // SAFE VIST, AGA POST EI OLE?
        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return RedirectToAction(nameof(SelectGame));
            }
            // Important for going back to MainGame
            ViewBag.Player1Id = player1Id;
            ViewBag.Player2Id = player2Id;

            var world = _context.World
                .FirstOrDefault(m => m.WorldId == worldId);

            // Security
            if (world.Player1IdAcc != (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && world.Player2IdAcc != (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))))
            {
                return RedirectToAction("SelectGame", "Game");
            }

            ViewBag.PlayerIdWhoClicks = playerIdWhoClicks; // OverallStats
            ViewBag.Owner = Owner;
            ViewBag.SelectedTower = SelectedTower;
            ViewBag.WorldId = worldId;

            var idWhereArmyGoes = (from d in _context.Tower where d.TowerId == SelectedTower select d).First();

            if (User.Identity.IsAuthenticated) // If account is logged in
            {
                var playerId = (from d in _context.Player
                                where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && d.WorldId == worldId //&& d.PlayerId == Owner
                                select d.PlayerId).FirstOrDefault();

                ViewBag.playerId = playerId;

                if (playerId == Owner) // The clicked tower is his own
                {
                    List<Player> mainBase = new List<Player>();
                    mainBase = (from d in _context.Player where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) && d.PlayerId == Owner select d).ToList();
                    ViewBag.mainBase = mainBase;

                    List<Tower> towerList2 = new List<Tower>();
                    towerList2 = (from product in _context.Tower where product.Owner == playerIdWhoClicks && product.WorldId == worldId select product).ToList();
                    ViewBag.ListofTower = towerList2;

                    int[] roundsToArrives_X = new int[towerList2.Count];
                    int[] roundsToArrives_Y = new int[towerList2.Count];
                    int[] arrival = new int[towerList2.Count];

                    int counter = 0;
                    for (int i = 0; i < towerList2.Count; i++)
                    {
                        if (towerList2[i].TowerId != SelectedTower) // Dont show the clicked tower?
                        {
                            int roundsToArriveCheckX = towerList2[i].LocationX - Convert.ToInt32(idWhereArmyGoes.LocationX);
                            int roundsToArriveCheckY = towerList2[i].LocationY - Convert.ToInt32(idWhereArmyGoes.LocationY);

                            if (roundsToArriveCheckX >= 0)
                                roundsToArrives_X[i] = roundsToArriveCheckX;
                            else
                            {
                                roundsToArriveCheckX *= -1;
                                roundsToArrives_X[i] = roundsToArriveCheckX;

                            }
                            if (roundsToArriveCheckY >= 0)
                                roundsToArrives_Y[i] = roundsToArriveCheckY;
                            else
                            {
                                roundsToArriveCheckY *= -1;
                                roundsToArrives_Y[i] = roundsToArriveCheckY;
                            }
                            arrival[counter] = roundsToArrives_X[i] + roundsToArrives_Y[i];
                            counter++;
                        }
                    }
                    ViewBag.Arrival = arrival;

                    List<int> LoggedInPlayerTowers = new List<int>();
                    foreach (var item in towerList2) // Add TowerId-s to another List, so it's faster loading
                    {
                        LoggedInPlayerTowers.Add(item.TowerId);
                    }
                    ViewBag.loggedInPlayerTowers = LoggedInPlayerTowers;

                    return View();
                }
                else // The clicked tower is enemy's OR Nobody's
                {
                    List<Tower> towerList2 = new List<Tower>();
                    towerList2 = (from product in _context.Tower
                                  where product.Owner == playerIdWhoClicks && product.WorldId == worldId // Logged in account ID
                                  select product).ToList();
                    ViewBag.ListofTower = towerList2;

                    int[] roundsToArrives_X = new int[towerList2.Count];
                    int[] roundsToArrives_Y = new int[towerList2.Count];
                    int[] arrival = new int[towerList2.Count];

                    for (int i = 0; i < towerList2.Count; i++)
                    {
                        int roundsToArriveCheckX = towerList2[i].LocationX - Convert.ToInt32(idWhereArmyGoes.LocationX);
                        int roundsToArriveCheckY = towerList2[i].LocationY - Convert.ToInt32(idWhereArmyGoes.LocationY);

                        if (roundsToArriveCheckX >= 0)
                            roundsToArrives_X[i] = roundsToArriveCheckX;
                        else
                        {
                            roundsToArriveCheckX *= -1;
                            roundsToArrives_X[i] = roundsToArriveCheckX;

                        }
                        if (roundsToArriveCheckY >= 0)
                            roundsToArrives_Y[i] = roundsToArriveCheckY;
                        else
                        {
                            roundsToArriveCheckY *= -1;
                            roundsToArrives_Y[i] = roundsToArriveCheckY;
                        }
                        arrival[i] = roundsToArrives_X[i] + roundsToArrives_Y[i];
                    }
                    ViewBag.Arrival = arrival; // Selle abil saadan need View ja Views ütleb, millal armee jõuab kohale. SIis ei pea ka Post'is enam seda kontrollima?
                    return View();
                }
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> SelectGame() // VIST SAFE
        {
            if (!User.Identity.IsAuthenticated) // If account is logged in
            {
                return View();
            }
            try
            {
                ViewBag.Queue = TempData["Queue"].ToString();
            }
            catch
            { }

            var playerIds = (from d in _context.Player where d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))) select d.PlayerId).ToList();

            var worlds = (from d in _context.World
                          where playerIds.Contains(d.Player1Id) || playerIds.Contains(d.Player2Id)
                          orderby d.WorldId descending
                          select new World
                          {
                              Player1IdAcc = d.Player1IdAcc,
                              Player2IdAcc = d.Player2IdAcc,
                              Player1Id = d.Player1Id,
                              Player2Id = d.Player2Id,
                              WorldId = d.WorldId,
                              GameFinished = d.GameFinished,
                              WinnerAccountId = d.WinnerAccountId,
                              Player1Ready = d.Player1Ready,
                              Player2Ready = d.Player2Ready
                          }).ToList();

            List<string> playerNames1 = new List<string>();
            List<string> playerNames2 = new List<string>();

            foreach (var world in worlds)
            {
                string player1 = (from d in _context.Playeraccount where d.AccountId == world.Player1IdAcc select d.AccountName).FirstOrDefault();
                playerNames1.Add(player1);

                string player2 = (from d in _context.Playeraccount where d.AccountId == world.Player2IdAcc select d.AccountName).FirstOrDefault();
                playerNames2.Add(player2);
            }
            ViewBag.playerNames1 = playerNames1;
            ViewBag.playerNames2 = playerNames2;

            List<string> youReady = new List<string>();
            List<string> enemyReady = new List<string>();

            foreach (var world in worlds)
            {
                if (world.Player1Ready == true ^ world.Player2Ready == true) // IF ONLY ONE OF THEM IS READY
                {
                    if (playerIds.Contains(world.Player1Id) && world.Player1Id == world.Player1Id && world.Player1Ready == true)
                    {
                        youReady.Add("YOU ARE READY");
                        enemyReady.Add("ENEMY IS NOT READY");
                    }
                    else if (!playerIds.Contains(world.Player1Id) && world.Player1Id == world.Player1Id && world.Player1Ready == true)
                    {
                        youReady.Add("YOU ARE NOT READY");
                        enemyReady.Add("ENEMY IS READY");
                    }
                    else if (playerIds.Contains(world.Player2Id) && world.Player2Id == world.Player2Id && world.Player2Ready == true)
                    {
                        youReady.Add("YOU ARE READY");
                        enemyReady.Add("ENEMY IS NOT READY");
                    }
                    else if (!playerIds.Contains(world.Player2Id) && world.Player2Id == world.Player2Id && world.Player2Ready == true)
                    {
                        youReady.Add("YOU ARE NOT READY");
                        enemyReady.Add("ENEMY IS READY");
                    }
                }
                else if (world.Player1Ready == false && world.Player2Ready == false) // CHECK IF BOTH ARE NOT READY
                {
                    youReady.Add("YOU ARE NOT READY");
                    enemyReady.Add("ENEMY IS NOT READY");
                }
            }
            ViewBag.You = youReady;
            ViewBag.Enemy = enemyReady;

            List<string> winnerNames = new List<string>();

            foreach (var world in worlds)
            {
                if (world.GameFinished == true)
                {
                    string winner = (from d in _context.Playeraccount where d.AccountId == world.WinnerAccountId select d.AccountName).FirstOrDefault();
                    if (winner == null)
                        winnerNames.Add("Account ID is " + Convert.ToString(world.WinnerAccountId));
                    else
                        winnerNames.Add("Name is " + winner);
                }
            }
            ViewBag.WinnerNames = winnerNames;

            if (worlds.Count <= 0)
            {
                ViewBag.Tutorial = 1;
                return View();
            }

            return View(worlds);
        }

        [HttpGet("Game/Tutorial/{FirstLogin?}")]
        public async Task<IActionResult> Tutorial(bool FirstLogin)
        {
            ViewBag.FirstLogin = FirstLogin;
            return View();
        }

        private bool TowerExists(int id)
        {
            return _context.Tower.Any(e => e.TowerId == id);
        }
    }
}
