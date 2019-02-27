using System;

namespace BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int[] arr)
        {
            int max = arr[0], i = 1, maxLen = 1, lastIndex = -1;
            while(i < arr.Length)
            {
                if (max.Equals(arr[i]) && !i.Equals(lastIndex))
                    maxLen++;
                if(arr[i] > max)
                {
                    lastIndex = i;
                    max = arr[i];
                    maxLen = 1;
                    i = 0;
                    continue;
                }
                i++;
            }
            return maxLen;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Console.WriteLine(birthdayCakeCandles(arr));
            Console.Read();
        }
    }
}
