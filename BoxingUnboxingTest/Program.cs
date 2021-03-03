using System;
using System.Diagnostics;

namespace BoxingUnboxingTest
{    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int n = 200;
            double q;
            q = n;
            int[] arr = new int[n];
            object[] o = new object[n];


            Console.WriteLine("Boxing...");
            sw.Start();
            for (int i = 0; i < n; i++)
            {
                o[i] = i;  
            }
            sw.Stop();
            Console.WriteLine("Boxing OK.");
            Console.WriteLine($"Общее время упаковки {n} элементов = {sw.ElapsedTicks}");
            Console.WriteLine($"Среднее время упаковки = {sw.ElapsedTicks / q}\n");
            sw.Reset();

            Console.WriteLine("Unboxing...");
            try
            {
                sw.Start();
                for (int j = 0; j < n; j++)
                {
                    int k = (int)o[j];  
                }
                sw.Stop();
                Console.WriteLine("Unboxing OK.");
                Console.WriteLine($"Общее время распаковки {n} элементов = {sw.ElapsedTicks}");
                Console.WriteLine($"Среднее время распаковки = {sw.ElapsedTicks / q}");
                sw.Reset();
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }
        }
    }

}
