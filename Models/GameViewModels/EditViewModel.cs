using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebGame.Models.WebGame;

namespace WebGame.ViewModel
{
    public class EditViewModel
    {
        public World World { get; set; }
        public Tower Tower { get; set; }

        public List<int> TowerId { get; set; }

        public List<int> TowerAttack { get; set; }
        public int mainBaseAttack { get; set; }
        public List<int> xCord { get; set; }
        public List<int> yCord { get; set; }

        public List<int> arrivingTime { get; set; }


        public int SelectedTowerId { get; set; }
        public int SelectedWorldId { get; set; }
        //public bool Connected { get; set; }
        //public int ArmyGoesTo { get; set; }
    }
}
