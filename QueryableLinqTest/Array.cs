using System;

namespace QueryableLinqTest
{
    class Array
    {
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("\nInt Array:");
            Console.WriteLine(string.Join(" ", arr));
        }

        public static void PrintArray(string[] arr)
        {
            Console.WriteLine("\nString Array:");
            Console.WriteLine(string.Join($"\n", arr));
        }

        public static void PrintArray(DateTime[] arr)
        {
            Console.WriteLine("\nDateTime Array:");
            Console.WriteLine(string.Join($"\n", arr));
        }

        public static void PrintArray(bool[] arr)
        {
            Console.WriteLine("\nBool Array:");
            Console.WriteLine(string.Join($"\n", arr));
        }

        public static void CreateArrayWithNElements(bool[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 2) == 0 ? true : false;
            }
        }
        public static void CreateArrayWithNElements(string[] arr)
        {
            Random random = new Random();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                string word = "";
                for (int j = 0; j < letters.Length; j++)
                {
                    int letter_num = random.Next(0, letters.Length - 1);
                    word += letters[letter_num];
                }

                arr[i] = word;
            }
        }

        public static void CreateArrayWithNElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * (int)Math.Pow(-1, i);
            }
        }
        public static void CreateArrayWithNElements(DateTime[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = DateTime.Now.AddHours(-i);
            }
        }
    }

}
