using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Parallelogram : Shape
    {
        public Parallelogram(double a, double b) : base(a, b) { }

        public override double Areal()
        {
            //𝑎𝑎 × 𝑏𝑏 × 𝑠𝑠𝑠𝑠𝑠𝑠(𝜃𝜃)
            return (this.a * this.b * Math.Sin(0));
        }

        public override double Perimeter()
        {
            return ((this.a * 2) + (this.b * 2));
        }
    }
}
