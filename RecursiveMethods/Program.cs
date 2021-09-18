using System;
using System.Linq;

namespace RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();

            Console.WriteLine(maths.CalculateExponential(3, 4));

            string name = "Şahin MARAL";
            
            Console.WriteLine(name.CheckSpaces());
            Console.WriteLine(name.RemoveSpaces());
            Console.WriteLine(name.MakeUpperCase());
            Console.WriteLine(name.MakeLowerCase());

            int[] numbers = { 10, 2, 4, 1 };
            numbers.SortArray();
        }
        
    }

    class Maths
    {
        public int CalculateExponential(int number, int exp)
        {
            if (exp<2)
            {
                return number;
            }

            return CalculateExponential(number, exp - 1) * number;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveSpaces(this string param)
        {
            if (CheckSpaces(param)) return param.Replace(" ", "");
            return param;
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
    }
}