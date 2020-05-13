using System;
using System.Collections.Generic;

namespace WebGame.Models.WebGame
{
    public partial class Aspnetuserclaims
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual Aspnetusers User { get; set; }
    }
}
