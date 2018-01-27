using System;
using System.Collections.Generic;

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

        public bool AddRacer(IDriveable racer)
        {
            Vehicles.Add(racer);
            return true;
        }

        public string PrintRacers()
        {
            string output = "";
            foreach(IDriveable car in Vehicles)
            {
                output = output + car.GetName() + " ";
                Console.WriteLine(car.GetName());
            }
            return output;
        }
    }
}
