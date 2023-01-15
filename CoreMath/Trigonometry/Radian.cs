using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMath.Trigonometry
{
    public class Radian : IAngle
    {
        public double Value { get; set; }
        public double GetExactValue()
        {
            return Value % Math.Tau > 0 ? Value % Math.Tau : Math.Tau + Value % Math.Tau;
        }

        public Radian ToRadian()
        {
            return this;
        }

        public Degree ToDegree()
        {
            var degree = new Degree();
            degree.Value = Value * 180 / Math.PI;
            return degree;
        }

        public Grad ToGrad()
        {
            var grad = new Grad();
            grad.Value = Value * 200 / Math.PI;
            return grad;
        }
    }
}
