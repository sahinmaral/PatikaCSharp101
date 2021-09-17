using System;
using System.Collections.Generic;

namespace HackerRankDay8
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            dictionaryCheck(length);
        }

        static void dictionaryCheck(int length)
        {
            var phoneBook = new Dictionary<string, int>();

            for (int i = 0; i < length; i++)
            {
                string[] phoneBookArray = Console.ReadLine().Split(' ');
                string name = phoneBookArray[0];
                int phone = int.Parse(phoneBookArray[1]);

                phoneBook.Add(name, phone);
            }

            string searchName = "";

            while ((searchName = Console.ReadLine()) != null)
            {
                if (phoneBook.ContainsKey(searchName))
                {
                    Console.WriteLine(searchName + "=" + phoneBook[searchName]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}