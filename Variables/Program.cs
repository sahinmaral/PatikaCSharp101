using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 byte
            byte byte1 = 5;
            sbyte sbyte1 = 5;

            
            //2 byte
            short shor1 = 5; 
            ushort uShort1 = 5;
            Int16 int161 = 2;
            char char1 = '2';
            
            //4 byte
            int int1 = 2;
            Int32 int321 = 2;
            uint uint1 = 2;
            float float1 = 5;
            
            //8 byte
            Int64 int641 = 2;
            long long1 = 4;
            double double1 = 5;
            
            //16 byte
            decimal decimal1 = 5;

            string string1 = "Şahin";

            bool bool1 = true;
            
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToString("dd.MM.yyyy"));
            Console.WriteLine(dateTime.ToString("HH:mm"));

            string name = "Şahin";
            string surname = "MARAL";
            string fullName = name + " " + surname;

            int number1 = 5;
            int number2 = 3;

            int totalNumber = number1 + number2;

            string randomString = name + " " + number1.ToString(); 
            Console.WriteLine(randomString);
            
            

        }
    }
}