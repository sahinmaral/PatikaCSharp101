using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            
            PlusMinus(arr);
        }
        
        public static void PlusMinus(List<int> arr)
        {
            int[] numbers = new int[arr.Count];

            double proportionPositive = 0;
            double proportionNegative = 0;
            double proportionZeros = 0;

            int countPositive = 0;
            int countNegative = 0;
            int countZeros = 0;
            
            for (int i = 0; i < arr.Count; i++)
            {
                numbers[i] = arr[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    countPositive++;
                }
                else if (numbers[i] == 0)
                {
                    countZeros++;
                }
                else
                {
                    countNegative++;
                }
            }

            proportionPositive = Convert.ToDouble(countPositive) / numbers.Length;
            proportionNegative = Convert.ToDouble(countNegative) / numbers.Length;
            proportionZeros = Convert.ToDouble(countZeros) / numbers.Length;

            Console.WriteLine(proportionPositive);
            Console.WriteLine(proportionNegative);
            Console.WriteLine(proportionZeros);
        }
    }
}