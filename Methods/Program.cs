using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 2;
            int val2 = 3;
            
            Methods methods = new Methods();
            methods.WriteOnScreen(Sum(val1,val2).ToString());

            methods.WriteOnScreen(methods.IncreaseOne(ref val1, ref val2).ToString());
        }

        static int Sum(int a, int b) => a + b;

    }

    class Methods
    {
        public void WriteOnScreen(string val)
        {
            Console.WriteLine(val);
        }

        public int IncreaseOne(ref int val1, ref int val2)
        {
            val1++;
            val2++;
            return val1 + val2;
        }
    }
}