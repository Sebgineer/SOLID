using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Square : Shape
    {
        public Square(double a) : base(a, a) { }

        public override double Perimeter()
        {
            return this.a * 4;
        }

        public override double Areal()
        {
            return this.a * this.a;
        }
    }
}
