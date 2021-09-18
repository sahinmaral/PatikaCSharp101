using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAboutCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstQuestion();
            SecondQuestion();
            ThirdQuestion();
        }

        static void FirstQuestion()
        {
            ArrayList primeNumbers = new ArrayList();
            ArrayList notPrimeNumbers = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number : ");

                int number = 0;

                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    continue;

                }


                if (!NumberCheck(number))
                {
                    continue;
                }


                if (PrimeCheck(number))
                {
                    primeNumbers.Add(number);
                }
                else
                {
                    notPrimeNumbers.Add(number);
                }
            }

            primeNumbers.Sort();
            notPrimeNumbers.Sort();

            primeNumbers.Reverse();
            notPrimeNumbers.Reverse();

            int sumOfPrimeNumber = 0;
            int sumOfNotPrimeNumber = 0;

            foreach (var primeNumber in primeNumbers)
            {
                sumOfPrimeNumber += (int) primeNumber;
            }

            foreach (var notPrimeNumber in notPrimeNumbers)
            {
                sumOfNotPrimeNumber += (int) notPrimeNumber;
            }

            Console.WriteLine($"Count of prime numbers : {primeNumbers.Count}");
            Console.WriteLine($"Count of not prime numbers : {notPrimeNumbers.Count}");
            Console.WriteLine($"Average of prime numbers : {(double)sumOfPrimeNumber / (double)primeNumbers.Count}");
            Console.WriteLine($"Average of not prime numbers : {(double)sumOfNotPrimeNumber / (double)notPrimeNumbers.Count}");

        }

        static bool NumberCheck(int val)
        {
            if (val < 0) return false;
            else return true;
        }

        static bool PrimeCheck(int val)
        {
            int counter = 0;

            if (val == 1 || val == 0)
            {
                return false;
            }

            else
            {
                for (int i = 2; i < val; i++)
                {
                    if (val % 2 == 0)
                    {
                        counter++;
                        break;
                    }
                }


                return counter == 1 ? false : true;
            }
        }

        static void ThirdQuestion()
        {
            var turkishVowels = new char[]
            {
                'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'
            };


            Console.Write("Enter a sentence : ");
            var sentence = Console.ReadLine().ToLower();

            var words = sentence.Split(' ');

            var vowelsOfSentence = new List<char>();

            foreach (var letter in sentence)
            foreach (var vowel in turkishVowels)
                if (letter == vowel)
                    if (!vowelsOfSentence.Contains(letter)) vowelsOfSentence.Add(letter);

            Console.WriteLine("Vowels of your sentence");

            foreach (var vowel in vowelsOfSentence) Console.WriteLine(vowel);

            Console.WriteLine("Words of your sentence");

            foreach (var word in words) Console.WriteLine(word);
        }

        static int[] BubbleSortIntArray(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j+1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        static void SecondQuestion()
        {
            int length = 5;
            
            int[] numbers = new int[length];
            int[] maxNumbers = new int[3];
            int[] minNumbers = new int[3];
            
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter a number : ");
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            numbers = BubbleSortIntArray(numbers);

            for (int i = 0; i < 3; i++)
            {
                minNumbers[i] = numbers[i];
            }

            numbers = numbers.Reverse().ToArray();

            for (int i = 0; i < 3; i++)
            {
                maxNumbers[i] = numbers[i];
            }

            double averageOfMaxNumbers = 0;
            double averageOfMinNumbers = 0;

            int sumOfMaxNumbers = 0;
            int sumOfMinNumbers = 0;

            foreach (var number in maxNumbers)
            {
                sumOfMaxNumbers += number;
            }

            foreach (var number in minNumbers)
            {
                sumOfMinNumbers += number;
            }
            
            averageOfMaxNumbers = (double)sumOfMaxNumbers / (double)maxNumbers.Length;
            averageOfMinNumbers = (double)sumOfMinNumbers / (double)minNumbers.Length;

            Console.WriteLine($"Average of Max Numbers : {averageOfMaxNumbers}");
            Console.WriteLine($"Average of Min Numbers : {averageOfMinNumbers}");
            Console.WriteLine($"Sum of Averages : {averageOfMaxNumbers+averageOfMinNumbers}");
        }
    }
}