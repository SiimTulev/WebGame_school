using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebGame.Models.WebGame;
using WebGame.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;

namespace WebGame.Data
{

    public class OverallStatsLogic : Controller
    {
        private readonly webgameContext _context;
        private readonly IdentityAppContext _identityContext;

        public OverallStatsLogic(webgameContext context, IdentityAppContext identityContext)
        {
            _context = context;
            _identityContext = identityContext;
        }
        public async Task<OverallStatsModel> GetOverallStats(int worldId, // queue matters. WorldId First, etc...
           int overallStatsPlayer1, int overallStatsPlayer2) // ENEMY playerId
        {

            //var findPlayerGold = (from d in _context.Player
            //                      where d.PlayerId == playerId && d.WorldId == worldId
            //                      select d.Gold).FirstOrDefault();

            var findGoldPlayer1 = (from d in _context.Player
                                   where d.PlayerId == overallStatsPlayer1 && d.WorldId == worldId
                                   select d).FirstOrDefault();

            _context.Entry(findGoldPlayer1).Reload();

            var findGoldPlayer2 = (from d in _context.Player
                                   where d.PlayerId == overallStatsPlayer2 && d.WorldId == worldId
                                   select d).FirstOrDefault();

            _context.Entry(findGoldPlayer2).Reload();

            // ViewBag.FindPlayerGold = findPlayerGold;

            var TowerSumPlayer1 = (from d in _context.Tower
                                   where d.Owner == overallStatsPlayer1 && d.WorldId == worldId
                                   select d).ToList();

            foreach (var entity in TowerSumPlayer1) if (entity != null) _context.Entry(entity).Reload();

            var TowerSumPlayer2 = (from d in _context.Tower
                                   where d.Owner == overallStatsPlayer2 && d.WorldId == worldId
                                   select d).ToList();

            foreach (var entity in TowerSumPlayer2) if (entity != null) _context.Entry(entity).Reload();

            int peopleNowPlayer1 = 0;
            int peopleGrowingPlayer1 = 0;
            int goldForTowersPlayer1 = 0;
            foreach (var tower in TowerSumPlayer1)
            {
                float? peopleGrowingPercentage = (100 + tower.TowerLvl) / 100f;
                float? peopleGrowed = peopleGrowingPercentage * tower.Attack;
                peopleNowPlayer1 += tower.Attack;
                peopleGrowingPlayer1 += Convert.ToInt32(peopleGrowed) - tower.Attack;
                goldForTowersPlayer1 += 10;

            }

            int peopleNowPlayer2 = 0;
            int peopleGrowingPlayer2 = 0;
            int goldForTowersPlayer2 = 0;
            foreach (var tower in TowerSumPlayer2)
            {
                float? peopleGrowingPercentage = (100 + tower.TowerLvl) / 100f;
                float? peopleGrowed = peopleGrowingPercentage * tower.Attack;
                peopleNowPlayer2 += tower.Attack;
                peopleGrowingPlayer2 += Convert.ToInt32(peopleGrowed) - tower.Attack;
                goldForTowersPlayer2 += 10;

            }


            var soonReturnsPlayer1 = (from d in _context.AttDef
                                      where d.AttackerPlayerId == overallStatsPlayer1 && d.WorldId == worldId && d.ReturnBase == true
                                      select d.Amount).ToList();

            foreach (var entity in soonReturnsPlayer1) if (entity != null) _context.Entry(entity).Reload();

            var soonReturnsPlayer2 = (from d in _context.AttDef
                                      where d.AttackerPlayerId == overallStatsPlayer2 && d.WorldId == worldId && d.ReturnBase == true
                                      select d.Amount).ToList();

            foreach (var entity in soonReturnsPlayer2) if (entity != null) _context.Entry(entity).Reload();


            int soonReturningPlayer1 = 0;
            foreach (var att in soonReturnsPlayer1)
            {
                soonReturningPlayer1 += att;
            }

            int soonReturningPlayer2 = 0;
            foreach (var att in soonReturnsPlayer2)
            {
                soonReturningPlayer2 += att;
            }
            //if (soonReturning > 0)
            //  ViewBag.SoonReturning = " + Army returning sometime (" + soonReturning + ")";

            //string view = "OverallStats";
            // string view = "Test";

            return new OverallStatsModel
            {
                Player1Id = TowerSumPlayer1[0].Owner,
                PeopleNowPlayer1 = peopleNowPlayer1,
                PeopleGrowingPlayer1 = " + People Growing (" + peopleGrowingPlayer1 + ")",
                SoonReturningPlayer1 = " + Army returning sometime (" + soonReturningPlayer1 + ")",
                FindPlayerGoldPlayer1 = findGoldPlayer1.Gold,
                goldForTowersPlayer1 = goldForTowersPlayer1,

                Player2Id = TowerSumPlayer2[0].Owner,
                PeopleNowPlayer2 = peopleNowPlayer2,
                PeopleGrowingPlayer2 = " + People Growing (" + peopleGrowingPlayer2 + ")",
                SoonReturningPlayer2 = " + Army returning sometime (" + soonReturningPlayer2 + ")",
                FindPlayerGoldPlayer2 = findGoldPlayer2.Gold,
                goldForTowersPlayer2 = goldForTowersPlayer2,
            };
        }
        public async Task<OverallStatsSingleModel> GetOverallStatsSingle(int worldId, // queue matters. WorldId First, etc...
       int playerId) // ENEMY playerId
        {

            var findPlayerGold = (from d in _context.Player
                                  where d.PlayerId == playerId && d.WorldId == worldId
                                  select d.Gold).FirstOrDefault();

            // ViewBag.FindPlayerGold = findPlayerGold;

            var towersSum = (from d in _context.Tower
                             where d.Owner == playerId && d.WorldId == worldId
                             select d).ToList();

            int peopleNow = 0;
            int peopleGrowing = 0;
            int goldForTowers = 0;
            foreach (var tower in towersSum)
            {
                float? peopleGrowingPercentage = (100 + tower.TowerLvl) / 100f;
                float? peopleGrowed = peopleGrowingPercentage * tower.Attack;
                peopleNow += tower.Attack;
                peopleGrowing += Convert.ToInt32(peopleGrowed) - tower.Attack;
                goldForTowers += 10;

            }

            //ViewBag.PeopleNow = peopleNow;
            // if (peopleGrowing > 0)
            // ViewBag.PeopleGrowing = " + People Growing (" + peopleGrowing + ")";
            // ViewBag.goldForTowers = goldForTowers;

            var soonReturns = (from d in _context.AttDef
                               where d.AttackerPlayerId == playerId && d.WorldId == worldId && d.ReturnBase == true
                               select d.Amount).ToList();

            int soonReturning = 0;
            foreach (var att in soonReturns)
            {
                soonReturning += att;
            }
            //if (soonReturning > 0)
            //  ViewBag.SoonReturning = " + Army returning sometime (" + soonReturning + ")";

            //string view = "OverallStats";
            // string view = "Test";

            return new OverallStatsSingleModel
            {
                PeopleNow = peopleNow,
                PeopleGrowing = " + People Growing (" + peopleGrowing + ")",
                SoonReturning = " + Army returning sometime (" + soonReturning + ")",
                FindPlayerGold = findPlayerGold,
                goldForTowers = goldForTowers
            };
        }
    }
}

