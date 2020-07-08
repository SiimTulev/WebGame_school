using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGame.Data
{
    public class OverallStatsModel
    {
        public int Player1Id { get; set; }
        public int PeopleNowPlayer1 { get; set; }
        public string PeopleGrowingPlayer1 { get; set; }
        public string SoonReturningPlayer1 { get; set; }
        public int FindPlayerGoldPlayer1 { get; set; }
        public int goldForTowersPlayer1 { get; set; }


        public int Player2Id { get; set; }
        public int PeopleNowPlayer2 { get; set; }
        public string PeopleGrowingPlayer2 { get; set; }
        public string SoonReturningPlayer2 { get; set; }
        public int FindPlayerGoldPlayer2 { get; set; }
        public int goldForTowersPlayer2 { get; set; }
    }
}
