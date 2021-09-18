using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.Startup();
        }
    }

    class PhoneBook
    {
        public PhoneBook()
        {
            Users = new List<User>()
            {
                new User() { Name = "Şahin", Phone = "02165961234", Surname = "MARAL" },
                new User() { Name = "Ali", Phone = "02165961234", Surname = "ÇALIŞKAN" },
                new User() { Name = "Fatma", Phone = "02165961234", Surname = "ZEKİ" },
                new User() { Name = "Veysel", Phone = "02165961234", Surname = "ZENGİN" },
                new User() { Name = "Cem", Phone = "02165961234", Surname = "YETMEZ" }
            };
        }

        public List<User> Users { get; set; }

        public void Startup()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Uygulamayı Kapat");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    AddUser();
                    break;
                }
                case 2:
                {
                    RemoveUser();
                    break;
                }
                case 3:
                {
                    UpdateUser();
                    break;
                }
                case 4:
                {
                    ListUsers();
                    break;
                }
                case 5:
                {
                    SearchUser();
                    break;
                }
                case 6:
                {
                    Environment.Exit(0);
                    break;
                }
            }
        }

        public void GetResultOfSearch(List<User> users)
        {
            Console.WriteLine("Arama sonuçlarınız:");
            Console.WriteLine("********************");
            foreach (var user in users)
            {
                Console.WriteLine($"isim : {user.Name}");
                Console.WriteLine($"soyisim : {user.Surname}");
                Console.WriteLine($"telefon : {user.Phone}");
                Console.WriteLine("********************");
            }
            
            Startup();
        }

        public void AddUser()
        {
            Console.Write("Lütfen isim giriniz: ");
            string name = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz: ");
            string surname = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz :");
            string phone = Console.ReadLine();

            Users.Add(new User()
            {
                Name = name,
                Surname = surname,
                Phone = phone
            });

            Console.WriteLine($"{name} isimli kullanıcı kaydedildi");
            Startup();
        }

        public void SearchUser()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim ve soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz:");

                    string name = Console.ReadLine();
                    string surname = Console.ReadLine();
                    
                    GetResultOfSearch(SearchUserByNameOrSurname(name,surname));
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin numarasını giriniz: ");

                    string phone = Console.ReadLine();
                    
                    GetResultOfSearch(SearchUserByPhone(phone));
                    
                    break;
                }
                default:
                {
                    WrongChoice();
                    break;
                }
            }
        }

        public void UpdateUser()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ve soyadını giriniz:");

            string name = Console.ReadLine();
            string surname = Console.ReadLine();

            List<User> foundUser = SearchUserByNameOrSurname(name, surname);
            if (foundUser == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

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
                        UpdateUser();
                        break;
                    }
                    default:
                    {
                        WrongChoice();
                        break;
                    }
                }
            }

            else
            {
                Console.Write($"{name} isimli kişi güncellenmek üzere, onaylıyor musunuz ?(y/n)");
                string choice = Console.ReadLine();
                if (choice.Equals("y"))
                {
                    UpdateChoice(foundUser);
                }
                else if (choice.Equals("n"))
                {
                    Console.WriteLine("İşleminiz reddedildi");
                    Startup();
                }
                else
                {
                    WrongChoice();
                    Startup();
                }
            }
        }

        private void UpdateChoice(List<User> foundUser)
        {
            Console.WriteLine("Hangi bilgisini güncellemek istiyorsunuz ? ");
            Console.WriteLine("(1) İsim");
            Console.WriteLine("(2) Soyisim");
            Console.WriteLine("(3) Telefon");
            Console.WriteLine("(4) Güncellemeden çık");

            int updateChoice = int.Parse(Console.ReadLine());
            switch (updateChoice)
            {
                case 1:
                {
                    Console.Write("Yeni bir isim giriniz : ");
                    string updatedName = Console.ReadLine();
                    foundUser[0].Name = updatedName;
                    Console.WriteLine("Kullanıcının adı değişmiştir");
                    UpdateChoice(foundUser);
                    break;
                }
                case 2:
                {
                    Console.Write("Yeni bir soyisim giriniz : ");
                    string updatedSurname = Console.ReadLine();
                    foundUser[0].Surname = updatedSurname;
                    Console.WriteLine("Kullanıcının soyadı değişmiştir");
                    UpdateChoice(foundUser);
                    break;
                }
                case 3:
                {
                    Console.Write("Yeni bir telefon giriniz : ");
                    string updatedPhone = Console.ReadLine();
                    foundUser[0].Phone = updatedPhone;
                    Console.WriteLine("Kullanıcının telefonu değişmiştir");
                    UpdateChoice(foundUser);
                    break;
                }
                case 4:
                {
                    Startup();
                    break;
                }
                default:
                {
                    WrongChoice();
                    break;
                }
                
            }
        }

        public static void WrongChoice()
        {
            Console.WriteLine("Yanlış tuşlama yaptınız");
        }

        public List<User> SearchUserByNameOrSurname(string name, string surname)
        {
            return Users.Where(x => x.Name == name || x.Surname == surname).ToList();
        }

        public List<User> SearchUserByPhone(string phone)
        {
            return Users.Where(x => x.Phone == phone).ToList();
        }

        public void RemoveUser()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz:");

            string name = Console.ReadLine();
            string surname = Console.ReadLine();

            List<User> foundUser = SearchUserByNameOrSurname(name, surname);
            if (foundUser == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

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
                        RemoveUser();
                        break;
                    }
                    default:
                    {
                        WrongChoice();
                        break;
                    }
                }
            }


            else
            {
                Console.Write($"{name} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string choice = Console.ReadLine();
                if (choice.Equals("y"))
                {
                    Users.Remove(foundUser[0]);
                    Console.WriteLine($"{name} isimli kişi rehberden silindi");
                    
                    Startup();
                }
                else if (choice.Equals("n"))
                {
                    Console.WriteLine("İşleminiz reddedildi");
                    Startup();
                }
                else
                {
                    WrongChoice();
                    Startup();
                }
            }
        }


        public void ListUsers()
        {
            Console.WriteLine("Telefon rehberi:");
            Console.WriteLine("********************");
            foreach (var user in Users)
            {
                Console.WriteLine($"isim : {user.Name}");
                Console.WriteLine($"soyisim : {user.Surname}");
                Console.WriteLine($"telefon : {user.Phone}");
                Console.WriteLine("********************");
            }
            
            Startup();
        }
    }

    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}