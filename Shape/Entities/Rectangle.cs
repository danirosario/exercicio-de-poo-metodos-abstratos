using Shape.Entities.Enums;
using Shape.Entities;

namespace Shape.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() { }

        public Rectangle(double width, double height, int color) : base((Color)color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

    }
}
