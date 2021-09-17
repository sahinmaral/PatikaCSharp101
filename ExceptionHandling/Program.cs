using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Enter one number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number : "+number);
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine("Lütfen sadece sayı giriniz , "+exception.Message);
            }
            finally
            {
                Console.WriteLine("Birinci try tamamlandı");
            }

            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("-20000000000000");
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine("Boş değer girdiniz , " + exception.Message);
            }
            catch (OverflowException exception)
            {
                Console.WriteLine("Çok küçük veya büyük değer girdiniz , " + exception.Message);
            }
            

            Console.ReadKey();


        }
    }
}