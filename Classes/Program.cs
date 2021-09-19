using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                Name = "Şahin", Surname = "MARAL", Number = 5, Department = "Computer Engineering"
            };
            
            employee1.GetInfos();
        }
    }

    class Employee
    {
        public string Name { get; set; }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value.ToUpper(); }
        }

        public int Number { get; set; }
        public string Department { get; set; }

        public void GetInfos()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Number : {Number}");
            Console.WriteLine($"Department : {Department}");
        }
    }
}
