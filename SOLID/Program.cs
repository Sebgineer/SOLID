using System;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Square(14),
                new Rectangle(12, 24),
                new Parallelogram(24, 52),
                new Trapezoid(12, 14, 12, 26),
                new Triangle(42, 76, 23) 
            };

            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine($"A: {item.Areal()}");
                Console.WriteLine($"O: {item.Perimeter()}\n");
            }
        }
    }
}
