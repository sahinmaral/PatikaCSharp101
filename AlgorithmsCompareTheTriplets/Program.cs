using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsCompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            Console.WriteLine(String.Join(" ", CompareTriplets(a, b)));

        }
        
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int winForA = 0;
            int winForB = 0;
            
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) winForA++;
                else if (a[i] < b[i]) winForB++;
            }

            List<int> wins = new List<int>();
            wins.Add(winForA);
            wins.Add(winForB);

            return wins;
        }
    }
}