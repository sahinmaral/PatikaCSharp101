using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace ToDoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoApp app = new ToDoApp();
            app.Startup();
        }
    }


    class ToDoApp
    {
        private List<Mission> toDoList = new List<Mission>();
        private List<Mission> inProgressList = new List<Mission>();
        private List<Mission> doneList = new List<Mission>();

        private List<User> users = new List<User>()
        {
            new User(1,"Şahin","MARAL"),
            new User(2,"Zeki","MARAL"),
            new User(3,"Ali","MARAL"),
        };


        enum CardSize
        {
            XS = 1,
            S = 2,
            M = 3,
            L = 4,
            XL = 5
        }

        private static CardSize FindSizeEnumByNumber(int number)
        {
            CardSize returnSize = (CardSize) 0;

            switch (number)
            {
                case 1:
                {
                    returnSize = CardSize.XS;
                    break;
                }
                case 2:
                {
                    returnSize = CardSize.S;
                    break;
                }
                case 3:
                {
                    returnSize = CardSize.M;
                    break;
                }
                case 4:
                {
                    returnSize = CardSize.L;
                    break;
                }
                case 5:
                {
                    returnSize = CardSize.XL;
                    break;
                }
                default:
                {
                    Console.WriteLine("Hatalı giriş yaptınız");
                    break;
                }
            }

            return returnSize;
        }

        public ToDoApp()
        {
            toDoList.Add(new Mission()
            {
                CardSizeNumber = 3,
                Title = "Write Unit Test",
                Description = "Use latest framework",
                DeclaredPerson = FindUserById(1)
            });

            inProgressList.Add(new Mission()
            {
                CardSizeNumber = 2,
                Title = "Publish Google Play Store",
                Description = "It has to be done today",
                DeclaredPerson = FindUserById(2)
            });

            doneList.Add(new Mission()
            {
                CardSizeNumber = 4,
                Title = "Fix Bugs",
                Description = "!!!",
                DeclaredPerson = FindUserById(3)
            });

        }

        public void Startup()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Uygulamadan Çıkmak");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    ListBoard();
                    break;
                }
                case 2:
                {
                    AddMission();
                    break;
                }
                case 3:
                {
                    DeleteMission();
                    break;
                }
                case 4:
                {
                    MoveMission();
                    break;
                }
                case 5:
                {
                    Environment.Exit(0);
                    break;
                }
                default:
                {
                    WrongChoice();
                    Startup();
                    break;
                }
            }
        }

        private User FindUserById(int id)
        {
            return users.Find(x => x.Id == id);
        }

        private void MoveMission()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız : ");
            string title = Console.ReadLine();

            if (!CheckCardByTitle(title))
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    {
                        Startup();
                        break;
                    }
                    case 2:
                    {
                        MoveMission();
                        break;
                    }
                    default:
                    {
                        WrongChoice();
                        Startup();
                        break;
                    }
                }
            }

            else
            {
                int lineNumber = 0;

                lineNumber = FindToDoCardByTitle(title) != null ? 1 :
                    FindInProgressCardByTitle(title) != null ?  2 : 3;
                
                Mission foundMission = FindCardByLineNumberAndTitle(lineNumber,title);
                
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine($"Başlık      : {foundMission.Title}");
                Console.WriteLine($"İçerik      : {foundMission.Description}");
                Console.WriteLine($"Atanan Kişi : {foundMission.DeclaredPerson.Name + " " + foundMission.DeclaredPerson.Surname}");
                Console.WriteLine($"Büyüklük    : {FindSizeEnumByNumber(foundMission.CardSizeNumber)}");
                Console.WriteLine($"Line        : {FindLineByLineNumber(lineNumber)}");

                Console.WriteLine();

                DeleteCardByLineNumberAndTitle(lineNumber,title);

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    {
                        toDoList.Add(foundMission);
                        Startup();
                        break;
                    }
                    case 2:
                    {
                        inProgressList.Add(foundMission);
                        Startup();
                        break;
                    }
                    case 3:
                    {
                        doneList.Add(foundMission);
                        Startup();
                        break;
                    }
                    default:
                    {
                        WrongChoice();
                        Startup();
                        break;
                    }
                        
                }
            }
        }

        private string FindLineByLineNumber(int lineNumber)
        {
            string line = "";
            
            switch (lineNumber)
            {
                case 1:
                {
                    line = "TODO";
                    break;
                }
                case 2:
                {
                    line = "IN PROGRESS";
                    break;
                }
                case 3:
                {
                    line = "DONE";
                    break;
                }
            }

            return line;
        }

        private void DeleteCardByLineNumberAndTitle(int lineNumber , string title)
        {
            switch (lineNumber)
            {
                case 1:
                {
                    toDoList.Remove(toDoList.Find(x => x.Title == title));
                    break;
                }
                case 2:
                {
                    inProgressList.Remove(inProgressList.Find(x => x.Title == title));
                    break;
                }
                case 3:
                {
                    doneList.Remove(doneList.Find(x => x.Title == title));
                    break;
                }
                    
            }
        }

        private Mission FindCardByLineNumberAndTitle(int lineNumber,string title)
        {
            switch (lineNumber)
            {
                case 1:
                {
                    return toDoList.Find(x => x.Title == title);
                    break;
                }
                case 2:
                {
                    return inProgressList.Find(x => x.Title == title);
                    break;
                }
                case 3:
                {
                    return doneList.Find(x => x.Title == title);
                    break;
                }
            }

            return null;
        }

        private Mission FindInProgressCardByTitle(string title)
        {
            List<Mission> foundCards = new List<Mission>();

            foreach (var mission in inProgressList.Where(x=>x.Title == title))
            {
                foundCards.Add(mission);
            }
            
            return foundCards.Count > 0 ? foundCards[0] : null;
        }
        
        private Mission FindDoneCardByTitle(string title)
        {
            List<Mission> foundCards = new List<Mission>();

            foreach (var mission in doneList.Where(x=>x.Title == title))
            {
                foundCards.Add(mission);
            }
            
            return foundCards.Count > 0 ? foundCards[0] : null;
        }

        private void DeleteMission()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string title = Console.ReadLine();

            if (!CheckCardByTitle(title))
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    {
                        Startup();
                        break;
                    }
                    case 2:
                    {
                        DeleteMission();
                        break;
                    }
                    default:
                    {
                        WrongChoice();
                        Startup();
                        break;
                    }
                }
            }

            else
            {
                DeleteCardByTitle(title);
                Console.WriteLine($"{title} başlığındaki görevleriniz silinmiştir");
                Startup();
            }
            
        }

        private void DeleteCardByTitle(string title)
        {
            if (FindToDoCardByTitle(title) != null)
            {
                toDoList.Remove(toDoList.Find(x => x.Title == title));
            }
            else if (FindInProgressCardByTitle(title) != null)
            {
                inProgressList.Remove(inProgressList.Find(x => x.Title == title));
            }
            else
            {
                doneList.Remove(doneList.Find(x => x.Title == title));
            }
            
        }

        private void FindCardByTitle(string title)
        {
            List<Mission> foundCards = new List<Mission>();

            foreach (var mission in toDoList.Where(x=>x.Title == title))
            {
                foundCards.Add(mission);
            }
            
            foreach (var mission in inProgressList.Where(x=>x.Title == title))
            {
                foundCards.Add(mission);
            }
            
            foreach (var mission in doneList.Where(x=>x.Title == title))
            {
                foundCards.Add(mission);
            }
        }

        private Mission FindToDoCardByTitle(string title)
        {
            List<Mission> foundCards = new List<Mission>();

            foreach (var mission in toDoList.Where(x=>x.Title == title))
            {
                foundCards.Add(mission);
            }
            
            return foundCards.Count > 0 ? foundCards[0] : null;
        }

        private bool CheckCardByTitle(string title)
        {
            Mission found1 = toDoList.Find(x => x.Title == title);
            Mission found2 = inProgressList.Find(x => x.Title == title);
            Mission found3 = doneList.Find(x => x.Title == title);

            if (found1 != null || found2 != null || found3!= null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void AddMission()
        {
            Console.Write("Başlık Giriniz : ");
            string title = Console.ReadLine();
            
            Console.Write("İçerik Giriniz : ");
            string description = Console.ReadLine();
            
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
            int sizeNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Kişinin ID'sini Giriniz : ");
            int id = int.Parse(Console.ReadLine());

            if (CheckUser(id))
            {
                Mission mission = new Mission()
                {
                    DeclaredPerson = FindUserById(id),
                    Description = description,
                    CardSizeNumber = sizeNumber,
                    Title = title
                };
                
                toDoList.Add(mission);
                Console.WriteLine($"{title} başlığındaki göreviniz eklendi");
                Console.WriteLine();
                Startup();
            }
            else
            {
                Console.WriteLine($"{id} ID'li kullanıcı bulunamadı");
            }

            Startup();

        }

        private void ListBoard()
        {
            foreach (var mission in toDoList)
            {
                Console.WriteLine("TODO Line");
                Console.WriteLine("************************");
                Console.WriteLine($"Başlık : {mission.Title}");
                Console.WriteLine($"İçerik : {mission.Description}");
                Console.WriteLine($"Atanan Kişi : {mission.DeclaredPerson.Name + " " + mission.DeclaredPerson.Surname}");
                Console.WriteLine($"Büyüklük : {FindSizeEnumByNumber(mission.CardSizeNumber)}");
            }

            Console.WriteLine();

            foreach (var mission in inProgressList)
            {
                Console.WriteLine("IN PROGRESS Line");
                Console.WriteLine("************************");
                Console.WriteLine($"Başlık : {mission.Title}");
                Console.WriteLine($"İçerik : {mission.Description}");
                Console.WriteLine($"Atanan Kişi : {mission.DeclaredPerson.Name + " " + mission.DeclaredPerson.Surname}");
                Console.WriteLine($"Büyüklük : {FindSizeEnumByNumber(mission.CardSizeNumber)}");
            }

            Console.WriteLine();

            foreach (var mission in doneList)
            {
                Console.WriteLine("DONE Line");
                Console.WriteLine("************************");
                Console.WriteLine($"Başlık : {mission.Title}");
                Console.WriteLine($"İçerik : {mission.Description}");
                Console.WriteLine($"Atanan Kişi : {mission.DeclaredPerson.Name + " " + mission.DeclaredPerson.Surname}");
                Console.WriteLine($"Büyüklük : {FindSizeEnumByNumber(mission.CardSizeNumber)}");
            }

            Console.WriteLine();

            Startup();
        }

        private void WrongChoice()
        {
            Console.WriteLine("Hatalı giriş yaptınız");
        }

        private bool CheckUser(int id)
        {
            User foundUser = users.Find(x => x.Id == id);
            return foundUser == null ? false : true;
        }
    }

    class Mission
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public User DeclaredPerson { get; set; }
        public int CardSizeNumber { get; set; }
    }

    class User
    {
        private string _surname;
        
        public User(int id)
        {
            this.Id = id;
        }
        public User(int id,string name,string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname
        {
            get { return _surname;}
            set { _surname = value.ToUpper(); }
        }
    }
}