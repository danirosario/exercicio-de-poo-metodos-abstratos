using Shape.Entities.Enums;
using System;

namespace Shape.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, int color) : base((Color)color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
