using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGame.Data
{
    public class testModel
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c => a + b;

        //public DateTime Date { get; set; }

        //public int TemperatureC { get; set; }

        //public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        //public string Summary { get; set; }
    }
}

