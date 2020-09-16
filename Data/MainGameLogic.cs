using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebGame.Models.WebGame;
using WebGame.ViewModel;


namespace WebGame.Data
{
    public class MainGameLogic : Controller
    {

        private readonly webgameContext _context;


        public MainGameLogic(webgameContext context)
        {
            _context = context;
        }


        public async Task<List<TowerViewModel>> PlayerReady(int worldId, int playerId) // SAFE
        {
            var world = _context.World
              .FirstOrDefault(m => m.WorldId == worldId);

            await _context.Entry(world).ReloadAsync();

            if (world == null)
            {
                // return NotFound();
            }
            var player = _context.Player
                            .FirstOrDefault(m => m.WorldId == worldId && m.PlayerId == playerId);


            if (world.Player1Id == player.PlayerId && world.WorldId == worldId)
            {
                world.Player1Ready = true;
            }
            if (world.Player2Id == player.PlayerId && world.WorldId == worldId)
            {
                world.Player2Ready = true;
            }


            List<Tower> towerList = new List<Tower>();
            towerList = (from product in _context.Tower
                         where product.WorldId == worldId
                         select product).ToList();

            foreach (var entity in towerList) if (entity != null) await _context.Entry(entity).ReloadAsync();


            if (world.Player1Ready == true && world.Player2Ready == true)
            {
                var player1Gold = _context.Player
                 .FirstOrDefault(m => m.WorldId == worldId && m.PlayerId == world.Player1Id);

                var player2Gold = _context.Player
                 .FirstOrDefault(m => m.WorldId == worldId && m.PlayerId == world.Player2Id);

                await _context.Entry(player1Gold).ReloadAsync();
                await _context.Entry(player2Gold).ReloadAsync();

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
                moveChanging = (from m in _context.AttDef
                                where m.WorldId == worldId
                                select m).ToList();


                if (moveChanging.Count > 0) // if there is any army moving
                {
                    for (int i = 0; i < moveChanging.Count; i++)
                    {
                        moveChanging[i].RoundsToArrive -= 1;
                    }
                    _context.UpdateRange(moveChanging);
                }

                List<AttDef> armyToTower = new List<AttDef>(); // do army action
                armyToTower = (from m in _context.AttDef
                               where m.WorldId == worldId && m.RoundsToArrive <= 0
                               select m).ToList();

                if (armyToTower.Count > 0)
                {
                    Tower[] whereArmyGoes = new Tower[armyToTower.Count];
                    List<int> attackersDestination = new List<int>(); // Store enemy's army destination

                    for (int i = 0; i < armyToTower.Count; i++) // Friendly army must arrive first
                    {
                        whereArmyGoes[i] = (from d in _context.Tower
                                            where d.TowerId == armyToTower[i].TargetTowerId
                                            select d).First();

                        if (whereArmyGoes[i].Owner == armyToTower[i].AttackerPlayerId) // If army goes to friendly's base

                            whereArmyGoes[i].Attack += armyToTower[i].Amount;

                        else // If army goes enemy's base OR it's neutral base
                            attackersDestination.Add(i);
                    }

                    //await _context.Entry(whereArmyGoes).ReloadAsync();
                    foreach (var entity in towerList) if (entity != null) await _context.Entry(entity).ReloadAsync();


                    bool destroyedTower = false;
                    for (int i = 0; i < attackersDestination.Count; i++)
                    {
                        // && check if it's still the last attacker tower. If not, then enemy attacks it.
                        // tower is destroyed and add attacker's army to the base
                        if (destroyedTower == true && whereArmyGoes[attackersDestination[i]].Owner == armyToTower[i].AttackerPlayerId)
                        {
                            whereArmyGoes[attackersDestination[i]].Attack += armyToTower[attackersDestination[i]].Amount;
                        }
                        else // attack tower
                        {
                            // Calculate also the tower strength percentage (defence) 
                            float prepare = (100 - (whereArmyGoes[attackersDestination[i]].Defence)) / 100f;

                            float strength = armyToTower[attackersDestination[i]].Amount * prepare;
                            // another idea would be that it adds percentage to the army what is in army. So dont change army amount number instead tower's army amount.
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
                    _context.UpdateRange(whereArmyGoes); // would it be better if it's in LOOP?
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
            await _context.SaveChangesAsync();


            var towers = (from ep in _context.Tower
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
                          }).ToList();


            return towers;
        }

        public async Task<List<TowerViewModel>> MainGame(int player1Id, int player2Id, int? worldId, int? error)
        {
            var towers = (from ep in _context.Tower
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
                          }).ToList();

            return towers;
        }
    }
}
