using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(10,"Ayşe Yılmaz");
            users.Add(11,"Ahmet Yılmaz");
            users.Add(12,"Deniz Yılmaz");
            users.Add(13,"Arda Yılmaz");

            Console.WriteLine(users[12]);

            foreach (var user in users)
            {
                Console.WriteLine(user.Key + " " + user.Value);
            }

            Console.WriteLine(users.Count);

            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Şahin MARAL"));
            
            //In compiler time , you can add same key to the dictionary but 
            //you can get error during the runtime ; that's why 
            //your key should be unique 

            users.Remove(12);
            
            foreach (var user in users)
            {
                Console.WriteLine(user.Key + " " + user.Value);
            }
        }
    }
}