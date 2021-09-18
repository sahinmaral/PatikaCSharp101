using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
            
            Console.WriteLine(AVeryBigSum(ar));
        }
        
        public static long AVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach(var number in ar){
                sum += number;
            }
        
            return sum;
        }
    }
}