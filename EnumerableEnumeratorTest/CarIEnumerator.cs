using System;
using System.Collections;

namespace EnumerableEnumeratorTest
{
    public class CarIEnumerator : IEnumerator
    {
        public Car[] _car;
        int position = -1;

        public CarIEnumerator(Car[] list)
        {
            _car = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _car.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Car Current
        {
            get
            {
                try
                {
                    return _car[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

}
