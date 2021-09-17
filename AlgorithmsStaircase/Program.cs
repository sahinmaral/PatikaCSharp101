using System;

namespace AlgorithmsStaircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            
            MakeStaircase(length);
        }

        static void MakeStaircase(int number)
        {
            int temp = number;
            
            for (int i = 0; i < number; i++)
            {
                for (int j = 1; j < temp; j++)
                {
                    Console.Write(" ");
                }

                for (int j = number; j >= temp; j--)
                {
                    Console.Write("#");
                }
                
                temp--;
                Console.WriteLine("");
            }
        }
    }
}