using System;
using System.Collections.Generic;

namespace WebGame.Models.WebGame
{
    public partial class Tower
    {
        public int TowerId { get; set; }
        public int WorldId { get; set; }
        public int Owner { get; set; }
        public string TowerName { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int TowerLvl { get; set; }
    }
}
