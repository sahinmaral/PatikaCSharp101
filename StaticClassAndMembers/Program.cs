using System;

namespace StaticClassAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Employee Count : {Employee.EmployeeCount}");

            Employee employee1 = new Employee("Şahin", "MARAL", "Computer Engineering");
            
            Console.WriteLine($"Employee Count : {Employee.EmployeeCount}");

            Console.WriteLine(Process.ConvertTextToLower("Şahin"));

            Console.WriteLine(Process.ConvertTextToUpper("maral"));
        }
    }
    
    static class Process
    {
        public static string ConvertTextToUpper(string text)
        {
            return text.ToUpper();
        }
        
        public static string ConvertTextToLower(string text)
        {
            return text.ToLower();
        }
    }

    class Employee
    {
        private static int employeeCount;

        public static int EmployeeCount
        {
            get { return employeeCount; }
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        static Employee()
        {
            employeeCount = 0;
        }

        public Employee(string name, string surname, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            employeeCount++;
        }
    }

    
}