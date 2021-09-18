using System;

namespace ConstructorFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Şahin", "maral", 10, "Computer Engineering");
            employee1.GetInfos();
        }
    }
    
    class Employee
    {
        public string Name { get; set; }

        private string _surname;

        public Employee(string name,string surname,int number,string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            this.Number = number;
        }
        
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