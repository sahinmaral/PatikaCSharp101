using System;

namespace HackerRankDay16
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                var i = int.Parse(S);
                Console.Write(i);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }

        }
    }
}