using System;

namespace OOPTest
{
    class Cube : Square
    {
        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (_height <= 0)
                    _height = value;
            }
        }
        public Cube(string color, double length, double width, double height) : base(color, length, width)
        {
            Height = height;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Куб\nЦвет = {Color}, длина = {Lenght}, ширина = {Width}, высота = {Height}");
        }
    }
}
