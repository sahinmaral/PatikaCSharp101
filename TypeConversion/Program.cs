using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Implicit Conversion *****");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d : " + d);

            long h = d;
            Console.WriteLine("h : " + h);

            float i = h;
            Console.WriteLine("i : " + i);

            string e = "şahin";
            char f = 'm';
            object g = e + f + d;
            Console.WriteLine("g : " + g);

            Console.WriteLine("***** Explicit Conversion *****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y : " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("z : " + z);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("w : " + w);

            Console.WriteLine("***** ToString Method *****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy);

            Console.WriteLine("***** System.Convert Class *****");

            string s1 = "10", s2 = "20";

            int number1, number2;
            int sum;

            number1 = Convert.ToInt32(s1);
            number2 = Convert.ToInt32(s2);

            sum = number1 + number2;
            Console.WriteLine("Sum of converted strings : " + sum);

            Console.WriteLine("***** Parse Method *****");

            string text1 = "10";
            string text2 = "10.25";

            int number3;
            double double1;

            number3 = int.Parse(text1);
            double1 = double.Parse(text2);

            Console.WriteLine("number3 : " + number3);
            Console.WriteLine("double1 : " + double1);
        }
    }
}