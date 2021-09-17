using System;

namespace HackerRankDay9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(factorial(number));
        }

        public static int factorial(int n)
        {
            if (n == 1) return 1;
            else
            {
                return n * factorial(n - 1);
            }
        }
    }
}