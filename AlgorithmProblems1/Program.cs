using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmProblems1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstQuestion();
            SecondQuestion();
            ThirdQuestion();
            ForthQuestion();
        }

        private static void SecondQuestion()
        {
            Console.Write("Write a length : ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Write a point number : ");
            int pointNumber = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < length; i++)
            {
                Console.Write("Write a number : ");
                int number = int.Parse(Console.ReadLine());

                if (number == pointNumber || number % pointNumber == 0)
                {
                    numbers.Add(number);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void ThirdQuestion()
        {
            Console.Write("Enter a number : ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine($"Write {length} words : ");

            string[] words = new string[length];
            for (int i = 0; i < length; i++)
            {
                string word = Console.ReadLine();
                words[i] = word;
            }

            words = words.Reverse().ToArray();

            foreach (var word in words)
            {
                Console.Write(word);
            }
        }

        private static void ForthQuestion()
        {

            Console.WriteLine("Write a sentence : ");
            
            string text = Console.ReadLine();

            if (text != null)
            {
                string[] words = text.Split(' ');

                Console.WriteLine($"Total words : {words.Length}");
                int totalLetter = 0;

                foreach (var letter in text.Replace(" ", ""))
                {
                    totalLetter++;
                }

                Console.WriteLine($"Total lettter : {totalLetter}");
            }
            else
            {
                Console.WriteLine("Your sentence is null");
            }
            
        }

        private static void FirstQuestion()
        {
            Console.Write("Enter a positive number : ");
            int length = int.Parse(Console.ReadLine());

            if (length < 0)
            {
                Console.WriteLine("You wrote negative number");
            }
            else
            {
                int[] numbers = new int[length];

                for (int i = 0; i < length; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                numbers = numbers.ReturnEvenNumbers();

                foreach (int number in numbers)
                    Console.Write(number);
            }
        }
    }

    static class Algorithm
    {
        public static int[] ReturnEvenNumbers(this int[] arr)
        {
            List<int> temp = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    temp.Add(arr[i]);
                }
            }

            return temp.ToArray();
        }
    }
}