using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebGame.Models.GameViewModels;
using WebGame.Models.WebGame;



namespace WebGame.ViewComponents
{
    public class OverallStatsViewComponent : ViewComponent
    {
        private readonly webgameContext _context;

        public OverallStatsViewComponent(webgameContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(
           int playerId, int worldId)
        {
            var findPlayerGold = (from d in _context.Player
                                  where d.PlayerId == playerId && d.WorldId == worldId
                                  select d.Gold).FirstOrDefault();

            ViewBag.FindPlayerGold = findPlayerGold;

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
            ViewBag.PeopleNow = peopleNow;
            if (peopleGrowing > 0)
                ViewBag.PeopleGrowing = " + People Growing (" + peopleGrowing + ")";
            ViewBag.goldForTowers = goldForTowers;

            var soonReturns = (from d in _context.AttDef
                               where d.AttackerPlayerId == playerId && d.WorldId == worldId && d.ReturnBase == true
                               select d.Amount).ToList();

            int soonReturning = 0;
            foreach (var att in soonReturns)
            {
                soonReturning += att;
            }
            if (soonReturning > 0)
                ViewBag.SoonReturning = " + Army returning sometime (" + soonReturning + ")";

            string view = "OverallStats";

            return View(view);
        }

    }
}
