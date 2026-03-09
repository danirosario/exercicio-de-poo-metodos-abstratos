using System;
using System.Collections.Generic;
using System.Globalization;
using ShapeProject.Entities;
using ShapeProject.Entities.Enums;

namespace ShapeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfShapes; i++)
            {
                Console.WriteLine($"Shape {i + 1} data: ");
                Console.WriteLine("Rectangle or Circle (r/c)?");
                char shapeType = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if (shapeType == 'r' || shapeType == 'R')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color ));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }

                Console.WriteLine("\n SHAPE AREAS: ");

            }
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

