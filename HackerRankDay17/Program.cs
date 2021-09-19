using System;

namespace HackerRankDay17
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator=new  Calculator();
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]); 
                try{
                    int ans=myCalculator.power(n,p);
                    Console.WriteLine(ans);
                }
                catch(Exception e){
                    Console.WriteLine(e.Message);

                }
            }

        }
    }

    class Calculator
    {
        public int power(int num1, int num2)
        {
            if (num1 < 0 || num2 < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            else
            {
                return (int)Math.Pow(num1, num2);
            }
        }
    }
}