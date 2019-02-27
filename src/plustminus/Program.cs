using System;

namespace plustminus
{
    class Program
    {
        static string ratioCalculator(double count, double total)
        {
            double result = (double)(count / total);
            return string.Format("{0:0.000000}", result);
        }
        static int greaterThanZero, lessThanZero, Zero;
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) greaterThanZero++;
                else if (arr[i] < 0) lessThanZero++;
                else Zero++;
            }
            Console.WriteLine(ratioCalculator(greaterThanZero, arr.Length));
            Console.WriteLine(ratioCalculator(lessThanZero, arr.Length));
            Console.WriteLine(ratioCalculator(Zero, arr.Length));
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }
    }
}
