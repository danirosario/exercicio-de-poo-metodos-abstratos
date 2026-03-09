using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfShapes; i++)
            {
                Console.WriteLine($"Shape {i + 1} data: ");
                Console.WriteLine("Rectangle or Circle (r/c)?");
                char shapeType = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red): ");
         

            }

        }
    }
}
