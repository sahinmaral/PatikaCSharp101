using System;

namespace HackerRankDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            seperateStrings(T);

            Console.ReadKey();
        }

        static void seperateStrings(int number)
        {
            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();

                string evenPart = "";
                string oddPart = "";

                for (int j = 0; j < text.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenPart += text[j];
                    }
                    else
                    {
                        oddPart += text[j];
                    }
                }

                Console.WriteLine(evenPart + " " + oddPart);
            }
        }
    }
}