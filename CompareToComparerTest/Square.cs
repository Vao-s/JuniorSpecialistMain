using System;

namespace CompareToComparerTest
{
    class Square : IComparable
    {
        private double _length;
        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                    _length = value;
                else
                    Console.WriteLine("Ошибка");
            }
        }

        public double Area { get; private set; }

        public Square(double length)
        {
            Length = length;
            Area = SquareFigure();
        }

        public double SquareFigure()
        {
            return Length * Length;
        }

        public int CompareTo(object other)
        {
            if (other == null) return 1;

            Square square = other as Square;
            if (square != null)
                return square.Area.CompareTo(this.Area);
            else
                throw new ArgumentException("Object is not a square");
        }
    }

}
