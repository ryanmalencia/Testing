using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Race
    {
        List<IDriveable> Vehicles;
        public Race(List<IDriveable> racers)
        {
            Vehicles = racers;
        }
        public Race()
        {
            Vehicles = new List<IDriveable>();
        }
    }
}
