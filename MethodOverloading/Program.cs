using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "999";
            
            bool status = int.TryParse(number, out int outNumber);
            if (status)
            {
                Console.WriteLine("Success");
                Console.WriteLine(outNumber);
            }
            else
            {
                Console.WriteLine("Fail");
            }

            int temp;
            
            Methods methods = new Methods();
            methods.Sum(2,3, out temp);
            
            methods.Sum(2,3);

            Console.WriteLine(temp);
        }
    }

    class Methods
    {
        public void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
}