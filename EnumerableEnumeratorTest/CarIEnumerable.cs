using System.Collections;

namespace EnumerableEnumeratorTest
{
    public class CarIEnumerable : IEnumerable
    {
        private Car[] _car;
        public CarIEnumerable(Car[] carArray)
        {
            _car = new Car[carArray.Length];

            for (int i = 0; i < carArray.Length; i++)
            {
                _car[i] = carArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public CarIEnumerator GetEnumerator()
        {
            return new CarIEnumerator(_car);
        }
    }

}
