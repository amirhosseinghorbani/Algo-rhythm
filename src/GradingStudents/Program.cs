using System;

namespace GradingStudents
{
    //problem url: https://www.hackerrank.com/challenges/grading
    public static class Program
    {
        public static int[] roundingGrades(int[] grades)
        {
            for(int i = 0; i < grades.Length; i++)
            {
                int mul = getNextMuliple5(grades[i]);
                if (IsValidToRound(grades[i], mul))
                    grades[i] = mul;
            }
            return grades;
        }

        private static int getNextMuliple5(int number)
        {
            int mod5 = (number % 5);
            if (mod5.Equals(0))
                return number;
            return getNextMuliple5(number + 1);
        }

        private static bool IsValidToRound(int number, int multipleOf) => (multipleOf - number) < 3 ? (true && number >= 37) : false;

        public static void Main(string[] args)
        {
            var len = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[len];
            for (int i = 0; i < len; i++)
                grades[i] = Convert.ToInt32(Console.ReadLine());
            int[] roundedGrades = roundingGrades(grades);
            for (int i = 0; i < len; i++)
                Console.WriteLine(roundedGrades[i]);

            Console.ReadKey();
        }
    }
}
