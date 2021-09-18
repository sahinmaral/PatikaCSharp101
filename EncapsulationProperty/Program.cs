using System;

namespace EncapsulationProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Name = "Şahin", Surname = "maral", Number = 5, Class = -1
            };

            student1.GetInfos();
            student1.DecreaseClass();
        }
    }

    class Student
    {
        private string _surname;
        private int _class;
        public string Name { get; set; }
        public string Surname
        {
            get => _surname;
            set => _surname = value.ToUpper();
        }
        public int Number { get; set; }

        public int Class
        {
            get
            {
                return _class;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Class must be greater equal than 1");
                    _class = 1;
                }
                else
                {
                    _class = value;
                }
            }
        }

        public Student(string name,string surname,int number,int _classNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
            this.Class = _classNumber;
        }

        public Student()
        {
            
        }

        public void GetInfos()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Number : {Number}");
            Console.WriteLine($"ClassName : {Class}");
        }

        public void IncreaseClass()
        {
            Class = Class + 1;
        }
        
        
        public void DecreaseClass()
        {
            if (Class == 1)
            {
                Console.WriteLine("Cannot decrease , class must be greater equal than 1");
            }
            else
            {
                Class = Class - 1;
            }
            
        }
    }
}