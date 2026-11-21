namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Завдання 1
            Реалізуйте користувацький тип "Фірма". 
            У ньому має бути інформація про назву фірми, дату заснування, 
            профіль бізнесу (маркетинг, IT, тощо), 
            ПІБ директора, кількість співробітників, адресу.

            Для масиву фірм реалізуйте такі запити:
            Отримати інформацію про всі фірми;
            Отримати фірми, у яких у назві є слово Food;
            Отримати фірми, які працюють у галузі маркетингу;
            Отримати фірми, які працюють у галузі маркетингу або IT;
            Отримати фірми з кількістю співробітників, більшою за 100;
            Отримати фірми з кількістю співробітників у діапазоні від 100 до 300;
            Отримати фірми, які знаходяться в Лондоні;
            Отримати фірми, у яких прізвище директора White;
            Отримати фірми, які засновані більше двох років тому;
            Отримати фірми з дня заснування, яких минуло 123 дні;
            Отримати фірми, у яких прізвище директора Black і назва фірми містить слово White.

            Завдання 2
            Реалізуйте запити з першого завдання з використанням синтаксису методів розширень.
            */

            Console.WriteLine("TASK-1,2");
            List<Firm> Firms = new List<Firm>();
            Firms.Add(new Firm("Apple", new DateTime(1999, 2, 4), "IT", "John", "Ternus", "Er", 3, "Paris"));
            Firms.Add(new Firm("NVidia", new DateTime(1999, 2, 3), "IT", "Jensen", "Huang", "Uoa", 2, "London"));
            Firms.Add(new Firm("AppleWorks", new DateTime(2015, 5, 10), "IT", "John", "Green", "A", 250, "London"));
            Firms.Add(new Firm("MarketPro", new DateTime(2020, 3, 15), "Marketing", "Bob", "White", "B", 100, "Paris"));
            Firms.Add(new Firm("WhiteMarket", new DateTime(2017, 8, 20), "Marketing", "Alice", "Black", "C", 300, "London"));
            Firms.Add(new Firm("WhiteTech", new DateTime(2024, 2, 10), "IT", "Sam", "White", "D", 301, "Kyiv"));
            Firms.Add(new Firm("MiniShop", new DateTime(2025, 1, 1), "Retail", "Eve", "Brown", "E", 99, "Odesa"));
            Firms.Add(new Firm("SuperPoint", new DateTime(2022, 6, 15), "Finance", "Tom", "Gray", "F", 101, "London"));
            Firms.Add(new Firm("WhiteBlack", new DateTime(2019, 4, 12), "IT", "Nick", "Black", "G", 150, "Berlin"));
            Firms.Add(new Firm("DateTest", DateTime.Now.AddDays(-123), "Services", "Anna", "White", "H", 200, "London"));

            Console.WriteLine("\n.1");
            var Firms01 = Firms;
            bool k01 = true;
            foreach (Firm f in Firms01) { Console.WriteLine(f); k01 = false; }
            if (k01) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.2");
            bool k02 = true;
            var Firms02 = Firms.Where(n => (n.Name).IndexOf("Food") != -1);
            foreach (Firm f in Firms02) { Console.WriteLine(f); k02 = false; }
            if (k02) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.3");
            bool k03 = true;
            var Firms03 = Firms.Where(n => n.BusinessProfile == "Marketing");
            foreach (Firm f in Firms03) { Console.WriteLine(f); k03 = false; }
            if (k03) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.4");
            bool k04 = true;
            var Firms04 = Firms.Where(n => n.BusinessProfile == "Marketing" || n.BusinessProfile == "IT");
            foreach (Firm f in Firms04) { Console.WriteLine(f); k04 = false; }
            if (k04) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.5");
            bool k05 = true;
            var Firms05 = Firms.Where(n => n.NumberOfEmploees > 100);
            foreach (Firm f in Firms05) { Console.WriteLine(f); k05 = false; }
            if (k05) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.6");
            bool k06 = true;
            var Firms06 = Firms.Where(n => n.NumberOfEmploees >= 100 && n.NumberOfEmploees <= 300);
            foreach (Firm f in Firms06) { Console.WriteLine(f); k06 = false; }
            if (k06) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.7");
            bool k07 = true;
            var Firms07 = Firms.Where(n => n.Adress == "London");
            foreach (Firm f in Firms07) { Console.WriteLine(f); k07 = false; }
            if (k07) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.8");
            bool k08 = true;
            var Firms08 = Firms.Where(n => n.CeoName.SName == "White");
            foreach (Firm f in Firms08) { Console.WriteLine(f); k08 = false; }
            if (k08) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.9");
            bool k09 = true;
            var Firms09 = Firms.Where(n => DateTime.Now - n.FoundingDate > new TimeSpan(365*2, 0, 0, 0));
            foreach (Firm f in Firms09) { Console.WriteLine(f); k09 = false; }
            if (k09) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.10");
            bool k10 = true;
            var Firms10 = Firms.Where(n => DateTime.Now - n.FoundingDate > new TimeSpan(122, 0, 0, 0) 
                && DateTime.Now - n.FoundingDate < new TimeSpan(124, 0, 0, 0));
            foreach (Firm f in Firms10) { Console.WriteLine(f); k10 = false; }
            if (k10) { Console.WriteLine("\n No data"); }

            Console.WriteLine("\n.11");
            bool k11 = true;
            var Firms11 = Firms.Where(n => n.CeoName.SName == "Black" && n.Name.IndexOf("White") != -1);
            foreach (Firm f in Firms11) { Console.WriteLine(f); k11 = false; }
            if (k11) { Console.WriteLine("\n No data"); }

            /* 
            Завдання 3
            Додайте до першого завдання клас, що містить інформацію про співробітників. Потрібно зберігати такі дані:
            ПІБ співробітника;
            Посада;
            Контактний телефон;
            Email;
            Заробітна плата.
            Додайте інформацію про співробітників усередину фірми.
            Для масиву співробітників фірми реалізуйте такі запити:
            Отримати всіх співробітників конкретної фірми;
            Отримати всіх співробітників конкретної фірми, у яких заробітні плати більші за задану;
            Отримати співробітників усіх фірм, у яких посада менеджер;
            Отримати співробітників, у яких телефон починається з 23;
            Отримати співробітників, у яких Email починається з di;
            Отримати співробітників, у яких ім'я Lionel.
             */
            Console.WriteLine("\n\nTASK-3");
            List<FirmWithEmploee> Firm = new List<FirmWithEmploee>{ 
                new FirmWithEmploee( Firms[0], new List<Emploee> {
                    new Emploee(new Name("John", "Borh", "Terance"), "Programmer", "1 096 011 12 09", "john_borh@gmail.com", 7800),
                    new Emploee(new Name("Lionel", "Van", "So"), "Designer", "23 096 011 12 09", "lionel_van@gmail.com", 6600),
                    new Emploee(new Name("Dio", "Lebran", "Godder"), "Manager", "23 888 077 45 25", "dio_lebran@gmail.com", 10200)
                }),
                new FirmWithEmploee( Firms[1], new List<Emploee> {
                    new Emploee(new Name("Muhhamad", "Gerr", "Et"), "Cleaner", "44 096 781 87 92", "muhhamad_gg@gmail.com", 1200),
                    new Emploee(new Name("Lu", "Shu", "Yan"), "Manager", "44 991 882 12 12", "liu_yan@gmail.com", 11700),
                })
            };

            
            Console.WriteLine("\n.1");
            Console.Write("Input company: ");
            string s1 = Console.ReadLine();
            bool k1 = false;
            foreach (FirmWithEmploee f in Firm)
            {
                if (f.Name != s1) { continue; }
                var Firm01 = f.Emploees;
                foreach (Emploee e in Firm01) { Console.WriteLine("Firm " + f.Name + ", emploee: " + e); k1 = true; }
            }
            if (!k1) Console.WriteLine("\nNo data");

            Console.WriteLine("\n.2");
            Console.Write("Input company: ");
            string s2 = Console.ReadLine();
            Console.Write("Input Salary: ");
            decimal.TryParse(Console.ReadLine(), out decimal Salary2);
            bool k2 = false;
            foreach (FirmWithEmploee f in Firm)
            {
                if (f.Name != s2) { continue; }
                var Firm02 = f.Emploees.Where(n => n.Salary > Salary2);
                foreach (Emploee e in Firm02) { Console.WriteLine("Firm " + f.Name + ", emploee: " + e); k2 = true; }
            }
            if (!k2) Console.WriteLine("\nNo data");

            Console.WriteLine("\n.3");
            bool k3 = false;
            foreach (FirmWithEmploee f in Firm)
            {
                var Firm03 = f.Emploees.Where(n => n.Position == "Manager");
                foreach (Emploee e in Firm03) { Console.WriteLine("Firm " + f.Name + ", emploee: " + e); k3 = true; }
            }
            if (!k3) Console.WriteLine("\nNo data");

            Console.WriteLine("\n.4");
            bool k4 = false;
            foreach (FirmWithEmploee f in Firm)
            {
                var Firm04 = f.Emploees.Where(n => n.PhoneNumber.StartsWith("23"));
                foreach (Emploee e in Firm04) { Console.WriteLine("Firm " + f.Name + ", emploee: " + e); k4 = true; }
            }
            if (!k4) Console.WriteLine("\nNo data");

            Console.WriteLine("\n.5");
            bool k5 = false;
            foreach (FirmWithEmploee f in Firm)
            {
                var Firm05 = f.Emploees.Where(n => n.Email.StartsWith("di"));
                foreach (Emploee e in Firm05) { Console.WriteLine("Firm " + f.Name + ", emploee: " + e); k5 = true; }
            }
            if (!k5) Console.WriteLine("\nNo data");

            Console.WriteLine("\n.6");
            bool k6 = false;
            foreach (FirmWithEmploee f in Firm)
            {
                var Firm06 = f.Emploees.Where(n => n.EmploeeName.FName == "Lionel");
                foreach (Emploee e in Firm06) { Console.WriteLine("Firm " + f.Name + ", emploee: " + e); k6 = true; }
            }
            if (!k6) Console.WriteLine("\nNo data");

            /*
            Завдання 4
            Для масиву цілих реалізуйте користувацьке сортування.   
            Сортування має працювати за сумою цифр числа (за зростанням і спаданням). 
            Наприклад, якщо сортування проводиться за спаданням, 
            потрібно повернути числа з максимальною сумою в порядку спадання суми. 
            Наприклад, якщо масив містить 121, 75, 81, після сортування за спаданням ми отримаємо 75, 81, 121.
            Такий результат, тому що (7+5 = 12, 8+1 = 9, 1+2+1 = 4).
             */
            Console.WriteLine("\n\nTASK-4");
            List<int> list = new List<int> ();
            string s;
            Console.WriteLine("Input number or \"Ex\" for exit: ");
            do
            {
                Console.Write("Input number: ");
                s = Console.ReadLine();
                if (s != "ex" && s != null && s != "")
                {
                    int.TryParse(s, out int temp);
                    list.Add(temp);
                }
            }
            while (s != "ex");

            Sort.MySort(ref list);

            Console.Write("Arr: ");
            foreach (int i in list) { Console.Write(i + " "); }
            Console.Write("\n\n");
        }
    }
}
