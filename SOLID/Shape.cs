using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public abstract class Shape
    {
        protected double a, b;

        public double A { get { return this.a; } set { this.a = value; } }
        public double B { get { return this.b; } set { this.b = value; } }

        protected Shape(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public abstract double Perimeter();
        public abstract double Areal();
    }
}
