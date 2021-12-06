using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Triangle : Shape
    {
        private double c;

        public double C { get { return this.c; } set { this.c = value; } }

        public Triangle(double a, double b, double c) : base(a, b) { }

        public override double Areal()
        {
            return (0.5) * this.a * this.b;
        }

        public override double Perimeter()
        {
            return this.a + this.b + this.c;
        }
    }
}
