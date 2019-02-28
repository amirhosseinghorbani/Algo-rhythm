using System;
using System.Collections.Generic;
using System.Linq;

namespace Pairs
{
    //problem url: https://www.hackerrank.com/challenges/pairs
    public static class Program
    {
        public static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            long len = Convert.ToInt32(firstLine[0]);
            long target = Convert.ToInt32(firstLine[1]);
            string[] strNumbers = Console.ReadLine().Split(' ');
            List<long> numbers = strNumbers.Select(x => Convert.ToInt64(x)).ToList();
            numbers.Sort();

            long result = calculatePairs(numbers, target);
            Console.WriteLine(result);
            Console.ReadLine();
        }


        private static long calculatePairs(List<long> numbers, long target)
        {
            long diff = 0;
            int i = 0, j = 1, ctr = 0;
            while(j < numbers.Count)
            {
                diff = numbers[j] - numbers[i];
                if (diff.Equals(target))
                {
                    ctr++;
                    j++;
                }
                else if (diff > target)
                    i++;
                else if (diff < target)
                    j++;
            }
            return ctr;
        }
    }
}
