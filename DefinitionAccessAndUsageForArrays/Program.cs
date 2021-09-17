using System;

namespace DefinitionAccessAndUsageForArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colours = new string[5];
            string[] animals = new[] { "dog", "cat", "cow", "duck", "giraffe" };

            Console.WriteLine(animals[3]);

            int[] arr;
            arr = new int[5];

            colours[0] = "brown";

            arr[3] = 5;

            Console.WriteLine(animals[1]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(colours[0]);

            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] arr2 = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter {i} number : ",i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;

            foreach (var number in arr2)
            {
                sum += number;
            }

            Console.WriteLine("Average arr2 : "+sum/arr2.Length);

        }
    }
}