using System;
using Library;

namespace OOPTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Blue", 10);
            Console.WriteLine($"{square.Color} квадрат со стороной {square.Length} имеет площадь {square.Area()}");

            Cube cube = new Cube("\nRed", 3); ;
            Console.WriteLine($"{cube.Color} куб со стороной {cube.Length} имеет площадь {cube.Area()}");


            Triangle triangle = new Triangle("\nBlack", 3, 4);
            Console.WriteLine($"{triangle.Color} треугольник со стороной {triangle.Length} и высотой {triangle.Height} имеет площадь {triangle.Area()}");
        }
    }
}
