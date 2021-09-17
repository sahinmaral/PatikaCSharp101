using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankDay10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(convertToBinaryNumber(125));
        }

        static int convertToBinaryNumber(int number)
        {
            List<int> consecutiveNumbers = new List<int>(); 
            
            List<int> remainings = new List<int>();

            int temp = 0;

            while (number != 0)
            {
                remainings.Add(number % 2);
                number = number / 2;
            }

            remainings.Reverse();

            for (int i = 0; i < remainings.Count; i++)
            {
                if (remainings[i] == 1 && i+1 == remainings.Count)
                {
                    temp++;
                    consecutiveNumbers.Add(temp);
                    temp = 0;
                }
                else if (remainings[i] == 1 && remainings[i+1] == 0)
                {
                    temp++;
                    consecutiveNumbers.Add(temp);
                    temp = 0;
                }
                else if (remainings[i] == 1 && remainings[i+1] == 1)
                {
                    temp++;
                }
            }

            return consecutiveNumbers.Max();
        }
    }
}