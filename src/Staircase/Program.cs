using System;
using System.Text;

namespace Staircase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= 1; j--)
                {
                    if (j > i)
                        Console.Write(' ');
                    else
                        Console.Write('#');
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
            Console.Read();
        }
    }
}
