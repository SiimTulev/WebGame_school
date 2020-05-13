using System;
using System.Collections.Generic;

namespace WebGame.Models.WebGame
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public int AccountId { get; set; }
        public int WorldId { get; set; }
        public int Gold { get; set; }
    }
}
