using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsBirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            BirthdayCakeCandles(candles);
        }
        
        public static int BirthdayCakeCandles(List<int> candles)
        {
            int max = 0;
            int sum = 0;
            
            foreach (var number in candles)
            {
                if (number > max)
                {
                    max = number;
                }   
            }

            foreach (var number in candles)
            {
                if (number == max)
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}