using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGame.Models.GameViewModels
{
    public class CancelArmyMovementViewModel
    {
        public int Id { get; set; }
        public int WorldId { get; set; }
        public int AttackerPlayerId { get; set; }
        public int TargetTowerId { get; set; }
        public int Amount { get; set; }
        public int RoundsToArrive { get; set; }
        public int AccountId { get; set; }
        public bool ReturnBase { get; set; }
        public string TowerName { get; set; }

    }
}
