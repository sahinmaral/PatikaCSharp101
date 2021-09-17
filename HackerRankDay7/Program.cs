using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankDay7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp))
                .ToList();

            reverseArray(arr);
        }

        static void reverseArray(List<int> arr)
        {
            int[] temp = new int[arr.Count];

            for (int i = 0; i < arr.Count; i++)
            {
                temp[arr.Count - 1 - i] = arr[i];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + " ");
            }
        }
    }
}