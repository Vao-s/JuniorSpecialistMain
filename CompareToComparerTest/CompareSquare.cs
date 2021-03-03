using System.Collections.Generic;

namespace CompareToComparerTest
{
    class CompareSquare<T> : IComparer<T>
        where T : Square
    {
        public int Compare(T x, T y)
        {
            if (x.Area < y.Area)
                return 1;
            if (x.Area > y.Area)
                return -1;
            else return 0;
        }
    }

}
