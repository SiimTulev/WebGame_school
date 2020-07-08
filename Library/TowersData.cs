//using DataAccessLibrary.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;
//using WebGame.Models.WebGame;

//namespace DataAccessLibrary
//{
//    class TowersData
//    {

//        private readonly webgameContext _context;

//        public TowersData(webgameContext context)
//        {
//            _context = context;
//        }


//        public Task<List<TowerModel>> GetTowers(TowerModel tower)
//        {

//            var world = _context.World
//  .FirstOrDefault(m => m.WorldId == tower.TowerId);

//            //var playerIdWhoClicks = (from d in _context.Player
//            //                         where d.WorldId == worldId && d.AccountId == (Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)))
//            //                         select d.PlayerId).FirstOrDefault();

//            _context.Update(playerIdWhoClicks);
//            _context.SaveChanges();


//            return world;

//            var towers = (from ep in _context.Tower
//                          join e in _context.World on ep.WorldId equals e.WorldId
//                          //where worldTowers.Contains(ep.Owner)
//                          where e.WorldId == worldId
//                          select new TowerViewModel
//                          {
//                              Id = ep.TowerId,
//                              Owner = ep.Owner,
//                              TowerId = ep.TowerId,
//                              Attack = ep.Attack,
//                              Defence = ep.Defence,
//                              WorldId = e.WorldId,
//                              Player1Id = e.Player1Id,
//                              Player2Id = e.Player2Id,
//                              Player1Ready = e.Player1Ready,
//                              Player2Ready = e.Player2Ready,
//                              TowerLvl = ep.TowerLvl,
//                              TowerName = ep.TowerName
//                          }).ToListAsync();


//            return View(towers);

//        }

//        public Task InsertPerson(TowerModel tower)
//        {
//            string sql = @"insert into dbo.People (FirstName, LastName, EmailAddress)
//                            values (@FirstName, @LastName, @EmailAddress);";

//            //return _db.SaveData(sql, tower);
//        }
//    }
//}
