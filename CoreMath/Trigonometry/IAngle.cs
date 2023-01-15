using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMath.Trigonometry
{
    public interface IAngle
    {
        public double Value { get; set; }


        public double GetExactValue();
        public Radian ToRadian();
        public Degree ToDegree();
        public Grad ToGrad();
    }
}
