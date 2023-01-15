using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreMath.Combinatorics.Functions;

namespace CoreMath.Trigonometry.Functions
{
    public class TrigonometricFunctions
    {
        public static double Sin(IAngle angle)
        {
            var degree = angle.ToDegree(); var radian = new Radian();
            if (degree.GetExactValue() > 90)
            {
                degree.Value = 180 - degree.GetExactValue();
            }

            
            radian = degree.ToRadian();
                double value = 0;
            for (int i = 0; i < 10; i++)
            {
                value += Math.Pow(-1, i) * Math.Pow(radian.GetExactValue(), i * 2 + 1) /
                         CombinatoricFunctions.Factorial((uint)(2 * i + 1));

            }

            return value;
        }
    }
}
//söz verildi