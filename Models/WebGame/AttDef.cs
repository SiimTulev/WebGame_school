using System;
using System.Collections.Generic;

namespace WebGame.Models.WebGame
{
    public partial class AttDef
    {
        public int Id { get; set; }
        public int WorldId { get; set; }
        public int AttackerPlayerId { get; set; }
        public int TargetTowerId { get; set; }
        public int Amount { get; set; }
        public int RoundsToArrive { get; set; }
        public int AccountId { get; set; }
        public bool ReturnBase { get; set; }
    }
}
