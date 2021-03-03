using System;

namespace Library
{
    public class Cube : Square
    {
        public Cube(string color, double length) : base(color, length) { }
        public override double Area()
        {
            return Length * Length * Length;
        }
    }
}
