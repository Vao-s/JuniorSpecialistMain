using System;

namespace OOPTest
{
    class Square : Figure
    {
        private double _lenght;
        private double _width;
        public double Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (_lenght <= 0)
                {
                    _lenght = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (_width <= 0)
                    _width = value;
            }
        }

        public Square(string color, double lenght, double width) : base(color)
        {
            Lenght = lenght;
            Width = width;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Квадрат\nЦвет = {Color}, длина = {Lenght}, ширина = {Width}");
        }
    }
}
