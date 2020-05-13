using System;
using System.Collections.Generic;

namespace WebGame.Models.WebGame
{
    public partial class Aspnetuserroles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual Aspnetroles Role { get; set; }
        public virtual Aspnetusers User { get; set; }
    }
}
