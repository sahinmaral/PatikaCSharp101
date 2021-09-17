using System;

namespace HackerRankDay3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine(CheckNumber(N));
        }

        public static string CheckNumber(int number)
        {
            if (number % 2 == 1)
            {
                return "Weird";
            }
            else
            {
                if (number <= 2 && number >= 5)
                {
                    return "Not Weird";
                }
                else if (number >= 6 && number <= 20)
                {
                    return "Weird";
                }
                else
                {
                    return "Not Weird";
                }
            }
        }
    }
}