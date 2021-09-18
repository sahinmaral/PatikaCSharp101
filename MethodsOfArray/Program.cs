using System;

namespace MethodsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 12, 4, 86, 72, 3, 11, 17 };

            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
            
            Array.Sort(arr);
            
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
            
            Array.Clear(arr,2,2);
            
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
            
            Array.Reverse(arr);
            
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(Array.IndexOf(arr, 23));
            
            
            
        }
    }
}