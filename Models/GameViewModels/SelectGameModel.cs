using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGame.Models.GameViewModels
{
    public class SelectGameModel
    {
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int WorldId { get; set; }
        public bool GameFinished { get; set; }
        public int WinnerAccountName { get; set; }

    }
}
