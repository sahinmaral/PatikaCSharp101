using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            List<string> colours = new List<string>();
            colours.Add("brown");
            colours.Add("green");
            colours.Add("yellow");
            colours.Add("red");

            Console.WriteLine($"colours.Count : {colours.Count}");
            
            colours.ForEach(x=>Console.WriteLine(x));

            colours.Remove("brown");
            numbers.RemoveAt(0);
            
            if(colours.Contains("brown")) Console.WriteLine("Brown found");
            else Console.WriteLine("Brown cannot find");
            
            colours.Clear();

            List<User> users = new List<User>();
            users.Add(new User()
            {
                Id = 1,
                FullName = "Şahin MARAL"
            });
            users.Add(new User()
            {
                Id = 2,
                FullName = "Ali MARAL"
            });

            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }
    }

    class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}