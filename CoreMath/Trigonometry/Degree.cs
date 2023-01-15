using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMath.Trigonometry
{
    public class Degree : IAngle
    { 
        

        public double Value { get; set; }
        public double GetExactValue()
        {
            return Value % 360 > 0 ? Value % 360 : 360 + Value % 360;
        }

        public Radian ToRadian()
        {
            var radian = new Radian();
            radian.Value = Value * Math.PI / 180;
            return radian;
        }

        public Degree ToDegree()
        {
            return this;
        }

        public Grad ToGrad()
        {
            var grad = new Grad();
            grad.Value = Value * 10 / 9;
            return grad;
        }
    }
}
