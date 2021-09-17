using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 1;
            int sum = 0;
            while (counter <= number)
            {
                sum += counter;
                counter++;
            }

            Console.WriteLine(sum/number);

            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            string[] cars = { "BMW", "Ford", "Toyota", "Lexus" };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}