using System;
using System.Collections;

namespace EnumerableEnumeratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] carArray = new Car[3]
            {
                new Car("BMW"),
                new Car("Lexus"),
                new Car("Toyota"),
            };

            Console.WriteLine("foreach:");
            CarIEnumerable carList = new CarIEnumerable(carArray);
            foreach (Car p in carList)
                Console.WriteLine($"Car: {p.carName}");

            Console.WriteLine("\nwhile:");
            IEnumerator cars = carArray.GetEnumerator();
            while (cars.MoveNext())
            {
                Car p = (Car)cars.Current;
                Console.WriteLine(p.ToString());
            }
        }
    }

}
