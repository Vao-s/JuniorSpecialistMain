using System;

namespace CloneableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Ben", Age = 23, Work = new Company { Name = "Microsoft" } };
            Person p2 = (Person)p1.Clone();

            p2.Work.Name = "Google";
            p2.Name = "Beef";
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Work.Name);
        }
    }

}
