using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMath.Trigonometry
{
    public class Grad : IAngle
    {
        public double Value { get; set; }
        
        public double GetExactValue()
        {
            return Value % 400 > 0 ? Value % 400 : 400 + Value % 400;
        }

        public Radian ToRadian()
        {
            var radian = new Radian();
            radian.Value = Value * Math.PI / 200;
            return radian;
        }

        public Degree ToDegree()
        {
            var degree = new Degree();
            degree.Value = Value * 9 / 10;
            return degree;
        }

        public Grad ToGrad()
        {
            return this;
        }
    }
}
