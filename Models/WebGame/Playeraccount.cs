using System;
using System.Collections.Generic;

namespace WebGame.Models.WebGame
{
    public partial class Playeraccount
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public int Wins { get; set; }
        public int Losts { get; set; }
    }
}
