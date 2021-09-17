using System;

namespace ForLoopBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int counter = int.Parse(Console.ReadLine());
            for (int i = 1; i <= counter; i++)
            {
                if (i%2==1)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("");

            int sumOfOddNumber = 0;
            int sumOfEvenNumber = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1) sumOfOddNumber += 1;
                else sumOfEvenNumber += 1;
            }

            Console.WriteLine("sumOfOddNumber : "+sumOfOddNumber);
            Console.WriteLine("sumOfEvenNumber : "+sumOfEvenNumber);

            for (int i = 0; i <= 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.Write(i);
            }
            
            for (int i = 0; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.Write(i);
            }
            
        }
    }
}