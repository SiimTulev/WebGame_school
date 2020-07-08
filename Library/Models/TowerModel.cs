using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class TowerModel
    {
        public int Id { get; set; }
        // TOWER 
        public int TowerId { get; set; }
        public int Owner { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public string TowerName { get; set; }

        // WORLD
        public int WorldId { get; set; }
        public string Player1Name { get; set; }
        public int Player1Id { get; set; }
        public string Player2Name { get; set; }
        public int Player2Id { get; set; }

        // OTHER
        public int PlayerId { get; set; }

        public bool Player1Ready { get; set; }
        public bool Player2Ready { get; set; }

        public int TowerLvl { get; set; }
    }
}
