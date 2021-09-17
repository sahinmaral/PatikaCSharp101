using System;

namespace HackerRankDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int i1 = int.Parse(Console.ReadLine());
            double d1 = Convert.ToDouble(Console.ReadLine());
            string s1 = Console.ReadLine();

            int result1 = i + i1;
            double result2 = d + d1;
            string result3 = s + s1;

            Console.WriteLine(result1);
            Console.WriteLine(result2.ToString("F1"));
            Console.WriteLine(result3);
        }
    }
}