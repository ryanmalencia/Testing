using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    interface IDriveable
    {
        bool AddDriver(Driver driver);
        int Accelerate(int percent);
        int Brake(int percent);
        int Turn(bool dir, int percent);
    }
}
