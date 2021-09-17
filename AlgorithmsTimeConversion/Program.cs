using System;
using System.IO;

namespace AlgorithmsTimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = Console.ReadLine();

            string result = TimeConversion(s);

            Console.WriteLine(result);
        }

        static string TimeConversion(string s)
        {
            string format = s.Substring(s.Length - 2, 2);

            s = s.Replace(format, "");

            string[] parts = s.Split(':');
            
            string hour = parts[0];
            string minute = parts[1];
            string second = parts[2];

            int hourNumber = 0;
            
            if (format == "PM")
            {
                if (hour == "12")
                {
                    hour = hour.ToString();
                }
                else
                {
                    hourNumber = int.Parse(hour) + 12;
                    hour = hourNumber.ToString();
                }
                
            }
            else
            {
                if (int.Parse(hour) == 12)
                {
                    hour = "00";
                }
                else
                {
                    hour = hour.ToString();
                }

                
            }

            string all = hour + ":" + minute + ":" + second;

            return all;

        }
    }
}