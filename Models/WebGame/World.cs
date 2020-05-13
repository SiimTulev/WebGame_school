using System;
using System.Collections.Generic;

namespace WebGame.Models.WebGame
{
    public partial class World
    {
        public int WorldId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public bool GameStarted { get; set; }
        public bool GameFinished { get; set; }
        public int WinnerAccountId { get; set; }
        public bool Player1Ready { get; set; }
        public bool Player2Ready { get; set; }
        public int Player1IdAcc { get; set; }
        public int Player2IdAcc { get; set; }
    }
}
