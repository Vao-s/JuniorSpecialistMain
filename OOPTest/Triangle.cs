using System;

namespace OOPTest
{
    class Triangle : Figure
    {
        public Triangle(string color) : base(color) { }

        public override void PrintInfo()
        {
            Console.WriteLine($"Треугольник\nЦвет = {Color}");
        }
    }
}
