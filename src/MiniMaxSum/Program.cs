using System;

namespace MiniMaxSum
{
    //problem url: https://www.hackerrank.com/challenges/mini-max-sum
    class Program
    {
        static void miniMaxSum(long[] arr)
        {
            long min = arr[0], max = arr[0], sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
                if(arr[i] < min)
                    min = arr[i];
                sum += arr[i];
            }
            Console.WriteLine($"{sum-max} {sum-min}");
        }

        static void Main(string[] args)
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            miniMaxSum(arr);
            Console.Read();
        }
    }
}
