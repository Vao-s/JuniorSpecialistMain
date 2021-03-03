using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryableLinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] intArray = new int[n];
            string[] stringArr = new string[n];
            DateTime[] dateTimeArr = new DateTime[n];
            bool[] boolArr = new bool[n];

            Array.CreateArrayWithNElements(intArray);
            Array.CreateArrayWithNElements(stringArr);
            Array.CreateArrayWithNElements(boolArr);
            Array.CreateArrayWithNElements(dateTimeArr);

            //Array.PrintArray(intArray);
            //Array.PrintArray(stringArr);
            //Array.PrintArray(dateTimeArr);
            //Array.PrintArray(boolArr);

            Console.WriteLine("\nArray Int - 0 < min < 50:");
            var selectedIntArrayMin = intArray.Where(min => min > 0 && min < 50).Min();
            Console.WriteLine(selectedIntArrayMin);

            Console.WriteLine("\nArray Int - max > 50:");
            var selectedIntArrayMax = intArray.Where(max => max > 50).Max();
            Console.WriteLine(selectedIntArrayMax);

            Console.WriteLine("\nArray Int - 0 < sum < 5:");
            var selectedIntArraySum = intArray.Where(sum => sum > 1 && sum < 5).Sum();
            Console.WriteLine(selectedIntArraySum);

            Console.WriteLine("\nSelected String Array - Starts with \"A\", order by: ");
            var selectedStringArray = stringArr.Where(t => t.ToLower().StartsWith("a")).OrderBy(t => t).ToArray();
            foreach (var t in selectedStringArray)
            {
                Console.WriteLine(t);
            }


            List<School> school = new List<School>
            {
                new School {Number=1, Town="Tiraspol" },
                new School {Number=2, Town="Bendery" },
                new School {Number=3, Town="Tiraspol" },
                new School {Number=4, Town="Bendery" },
                new School {Number=5, Town="Dybossary" },
                new School {Number=6, Town="Tiraspol" },
                new School {Number=7, Town="Dybossary" },
                new School {Number=8, Town="Tiraspol" }
            };
            var schoolGroups = school.GroupBy(p => p.Town);
            foreach (IGrouping<string, School> g in schoolGroups)
            {
                Console.WriteLine("\n" + g.Key);
                foreach (var t in g)
                    Console.WriteLine("School № " + t.Number);
            }

            bool isAllTiraspolSchools = school.All(u => u.Town == "Tiraspol"); // true
            if (isAllTiraspolSchools)
                Console.WriteLine("Все школы из Тирасполя");
            else
                Console.WriteLine("Все школы из разных городов");

            bool isAnySchool2 = school.Any(u => u.Number == 2); //false
            if (isAnySchool2)
                Console.WriteLine("В списке есть школа №2");
            else
                Console.WriteLine("В списке нет 2 школы");
        }
    }

}
