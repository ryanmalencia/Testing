using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Vehicle
    {
        protected Driver Driver;
        protected int Accel;
        protected int Brak;
        protected int Speed;
        protected int Passengers;
        protected int Wheels;
        protected int Weight;
        protected int Grip;
        protected int SteeringAngle;
        protected int MaxAngle;

        public Vehicle()
        {
            Driver = new Driver();
            Accel = 0;
            Brak = 0;
            Speed = 0;
            Passengers = 0;
            Wheels = 0;
            Weight = 0;
            Grip = 0;
            SteeringAngle = 0;
            MaxAngle = 70;
        }
    }
}
