using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibanocci_Solution
{
    public class Fibanocci
    {
        // constructor
        public Fibanocci() { }

        // Calculate Fibonici Series : 1,1,2,3,5,8,13...
        public int Calculate(int Position)
        {
            if (Position <= 1) return Position;
            else
                return Calculate(Position - 1) + Calculate(Position - 2);
        }
    }
}
