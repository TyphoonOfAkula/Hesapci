using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMath.Combinatorics.Functions
{
    public class CombinatoricFunctions
    {
        public static long Factorial(uint x)
        {
            if (x == 0 || x == 1)
                return 1;
            return x*Factorial(x- 1);
        }
    }
}
