using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsSimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = SimpleArraySum(ar);
        }
        
        public static int SimpleArraySum(List<int> ar)
        {
            int sum = 0;
        
            foreach(int number in ar){
                sum += number;
            }
        
            return sum;
        }  
    }
}