using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGame.Data
{
    public class TestService
    {
        public Task<testModel[]> test2(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new testModel
            {
                a = rng.Next(1, 5),
                b = rng.Next(1, 5)
            }).ToArray());
        }
    }
}
