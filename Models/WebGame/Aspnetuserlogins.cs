using System;
using System.Collections.Generic;

namespace WebGame.Models.WebGame
{
    public partial class Aspnetuserlogins
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public int UserId { get; set; }

        public virtual Aspnetusers User { get; set; }
    }
}
