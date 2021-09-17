using System;

namespace IfElseIfTernaryIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time<12)
            {
                Console.WriteLine("Good morning");
            }
            else if(time >= 12 && time <= 18)
            {
                Console.WriteLine("Good evening");
            }
            else
            {
                Console.WriteLine("Good night");
            }

            string result = time < 12 ? "Good morning" : time < 18 ? "Good evening" : "Good night";

            Console.WriteLine(result);
        }
    }
}