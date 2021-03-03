using System;

namespace TypeConversionTest.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "222";
            if (int.TryParse(str, out int i))
            {
                Console.WriteLine("Succes convert string to int");
                i = int.Parse(str);
                Console.WriteLine(i);
            }

            Animal vp = new Animal();
            Person p = vp;
            Animal vp2 = (Animal)p;
        }
    }

}
