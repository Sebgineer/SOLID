using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Rectangle : Shape
    {

        public Rectangle(double a, double b) : base(a, b) { }

        public override double Perimeter()
        {
            return ((this.a * 2) + (this.b * 2));
        }
        public override double Areal()
        {
            return (this.a * this.b);
        }
    }
}
