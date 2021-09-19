using System;
using System.Linq;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Our course is CSharp , Welcome";
            string text2 = "Our course is CSharp";

            Console.WriteLine(text1.Length);

            Console.WriteLine(text1.ToUpper());
            Console.WriteLine(text2.ToLower());

            text2.Concat(", Welcome");
            
            Console.WriteLine(text2);

            Console.WriteLine(text1.CompareTo(text2));

            Console.WriteLine(text1.Contains("CSharp"));

            Console.WriteLine(text1.EndsWith("Welcome"));
            Console.WriteLine(text1.StartsWith("Welcome"));

            Console.WriteLine(text1.IndexOf("CSharp"));

            Console.WriteLine(text1.Insert(0,"Hello , "));

            Console.WriteLine(text2.Remove(10));
            Console.WriteLine(text2.Remove(0,5));

            Console.WriteLine(text1.Replace("Welcome",""));

            Console.WriteLine(text1);
        }
    }
}