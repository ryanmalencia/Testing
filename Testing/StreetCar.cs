using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class StreetCar : Car, IDriveable
    {
        public bool AddDriver(Driver driver)
        {
            if (driver.Level > 0)
            {
                this.Driver = driver;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Accelerate(int percent)
        {
            this.Speed = this.Speed + this.Accel * percent / 100;
            return this.Speed;
        }

        public int Brake(int percent)
        {
            this.Speed = this.Speed - this.Brak * percent / 100;
            return this.Speed;
        }

        public int Turn(bool dir, int percent)
        {
            if (dir)
            {
                SteeringAngle = MaxAngle * percent / 100;
                return SteeringAngle;
            }
            else
            {
                SteeringAngle = (-1) * MaxAngle * percent / 100;
                return SteeringAngle;
            }
        }
    }
}
