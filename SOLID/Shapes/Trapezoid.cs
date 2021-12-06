using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Trapezoid : Shape
    {
        private double c;
        private double d;
        private double h;

        public double C { get { return this.c; } set { this.c = value; } }
        public double D { get { return this.d; } set { this.d = value; } }
        public double H { get { return this.h; } set { this.h = value; } }

        public Trapezoid(double a, double b, double c, double d) : base(a, b)
        {
            this.c = c;
            this.d = d;
        }

        public override double Areal()
        {
            double s = (this.a + this.b - this.c + this.d) / 2;
            this.h = ((2 / (this.a - this.c)) * (Math.Sqrt((s * (s - this.a + this.c) * (s - this.b) * (s - this.d)))));

            return (0.5 * this.h * (this.a + this.b));
        }

        public override double Perimeter()
        {
            return (this.a + this.b + this.c + this.d);
        }
    }
}
