using System;

namespace Library
{
    public class Triangle : Figure
    {
        private double _height;
        private double _length;
        public double Length
        {
            get
            {
                return _length;
            }
            private set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных");
                }
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }
            private set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных");
                }
            }
        }
        public Triangle(string color, double length, double height) : base(color)
        {
            Length = length;
            Height = height;
        }

        public override double Area()
        {
            return 0.5 * Height * Length;
        }
    }

}
