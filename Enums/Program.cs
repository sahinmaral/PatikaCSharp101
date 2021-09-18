using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            int heat = 14;

            if (heat <= (int)Weather.Normal)
                Console.WriteLine("It is cold");
            else if(heat >= (int)Weather.Hot)
                Console.WriteLine("It is hot");
            else if(heat >= (int)Weather.Normal && heat <= (int)Weather.Hot)
                Console.WriteLine("Let's go outside");
        }
        

        enum Weather
        {
            VeryCould = 0,
            Cold = 5,
            Normal = 15,
            Hot = 20,
            VeryHot = 25
        }
    }
}