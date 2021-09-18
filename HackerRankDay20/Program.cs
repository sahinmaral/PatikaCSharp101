using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankDay20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            
            BubbleSort(a, n);
        }

        private static void BubbleSort(List<int> a, int n)
        {
            int numberOfSwaps = 0;


            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        numberOfSwaps++;
                    }
                }

                if (numberOfSwaps == 0)
                {
                    break;
                }
            }

            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[n - 1]}");
        }
    }
}