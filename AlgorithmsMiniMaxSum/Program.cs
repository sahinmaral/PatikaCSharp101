using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsMiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int64> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp))
                .ToList();

            miniMaxSum(arr);
        }

        public static void miniMaxSum(List<Int64> arr)
        {
            List<Int64> sumOfNumbers = new List<Int64>();

            Int64 sum = 0;

            Int64 temp = 0;

            for (int j = 0; j < arr.Count; j++)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (temp != i)
                    {
                        sum += arr[i];
                    }
                }
                
                sumOfNumbers.Add(sum);
                temp++;
                sum = 0;
            }

            Console.Write(sumOfNumbers.Min() + " " + sumOfNumbers.Max());
            
        }
    }
}