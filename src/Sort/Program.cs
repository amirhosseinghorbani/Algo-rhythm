using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GenerateNumbers().ToArray();
            ISortAlgorithm<int> sort = new InsertionSort<int>();


            PrintArray<int>("list", arr);
            sort.Sort(arr);
            PrintArray<int>("sorted list", arr);

            Console.ReadLine();
        }

        static IEnumerable<int> GenerateNumbers()
        {
            int num = 0;
            Random rnd = new Random();
            while ((num = rnd.Next(0, 100)) != 0)
                yield return num;
        }

        static void PrintArray<T>(string title, T[] arr)
        {
            string strArr = string.Join(',', arr);
            Console.WriteLine($"{title}: {strArr}");
        }
    }
}
