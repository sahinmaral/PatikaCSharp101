using System;

namespace ConsoleProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name : ");
            string name = Console.ReadLine();
            
            Console.Write("Your surname : ");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Your name , surname : "+name+surname);
        }
    }
}