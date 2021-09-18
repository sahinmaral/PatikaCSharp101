using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsMigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp))
                .ToList();

            Console.WriteLine(MigratoryBirds(arr));
            
        }

        public static int MigratoryBirds(List<int> arr)
        {
            Dictionary<int, int> typesAndCounts = new Dictionary<int, int>();

            foreach (var number in arr)
            {
                if (!typesAndCounts.ContainsKey(number))
                {
                    typesAndCounts.Add(number, 0);
                }
            }
            

            for (int i = 0; i < arr.Count; i++)
            {
                if (typesAndCounts.ContainsKey(arr[i]))
                {
                    typesAndCounts[arr[i]]++;
                }
            }

            int sumOfMaxValue = 0;
            int maxValue = 0;

            for (int i = 0; i <= typesAndCounts.Count; i++)
            {
                if (!typesAndCounts.ContainsKey(i)) continue;
                else
                {
                    if (sumOfMaxValue < typesAndCounts[i])
                    {
                        sumOfMaxValue = typesAndCounts[i];
                        maxValue = i;
                    }
                }

            }

            return maxValue;
        }
    }
}