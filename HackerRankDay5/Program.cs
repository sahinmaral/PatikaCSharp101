using System;

namespace HackerRankDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            writeTableOfSum(n);
        }

        static void writeTableOfSum(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + number * i);
            }
        }
    }
}