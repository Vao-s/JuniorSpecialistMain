using System;

namespace Library
{
    public class Square : Figure
    {
        private double _length;
        public double Length
        {
            get
            {
                return _length;
            }
            private set
            {
                if (value>0)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных");
                }
            }
        }
        public Square(string color, double length) : base(color)
        {
            Length = length;
        }
        public override double Area()
        {
            return Length * Length;
        }
    }
}
