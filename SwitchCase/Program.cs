using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMonthName();
            WriteWeatherName();
        }

        private static void WriteWeatherName()
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Spring");
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Summer");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Autumn");
                    break;

                case 11:
                case 12:
                case 1:
                    Console.WriteLine("Winter");
                    break;
            }
        }

        private static void WriteMonthName()
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Wrong data");
                    break;
            }
        }
    }
}