using System;
using System.Collections.Generic;

namespace CompareToComparerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            CompareSquare<Square> compareSquare = new CompareSquare<Square>();
            List<Square> square = new List<Square>();
            for (int i = 0; i < 10; i++)
            {
                square.Add(new Square(random.Next(1, 10)));
                Console.WriteLine("");
            }

            square.Sort(compareSquare);
            square.ForEach(figures => Console.WriteLine(figures.SquareFigure()));
        }
    }

}
