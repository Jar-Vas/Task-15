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
            */
            Console.WriteLine("TASK-1");
            List<Firm> Firms = new List<Firm>();
            Firms.Add(new Firm("Apple", new DateTime(1999, 2, 4), "IT", "John", "Ternus", "Er", 25000, "C:/Users"));
            Firms.Add(new Firm("NVidia", new DateTime(1999, 2, 3), "IT", "Jensen", "Huang", "Uoa", 24999, "D:/Users"));
            Firms.Add(new Firm("AppleWorks", new DateTime(2015, 5, 10), "IT", "John", "Green", "A", 250, "London"));
            Firms.Add(new Firm("MarketPro", new DateTime(2020, 3, 15), "Marketing", "Bob", "White", "B", 100, "Paris"));
            Firms.Add(new Firm("WhiteMarket", new DateTime(2017, 8, 20), "Marketing", "Alice", "Black", "C", 300, "London"));
            Firms.Add(new Firm("WhiteTech", new DateTime(2024, 2, 10), "IT", "Sam", "White", "D", 301, "Kyiv"));
            Firms.Add(new Firm("MiniShop", new DateTime(2025, 1, 1), "Retail", "Eve", "Brown", "E", 99, "Odesa"));
            Firms.Add(new Firm("SuperPoint", new DateTime(2022, 6, 15), "Finance", "Tom", "Gray", "F", 101, "London"));
            Firms.Add(new Firm("WhiteBlack", new DateTime(2019, 4, 12), "IT", "Nick", "Black", "G", 150, "Berlin"));
            Firms.Add(new Firm("DateTest", DateTime.Now.AddDays(-123), "Services", "Anna", "White", "H", 200, "London"));

            Console.WriteLine(".1");
            var Firms01 = Firms;
            foreach (Firm f in Firms01) { Console.WriteLine(f); }

            Console.WriteLine(".2");
            var Firms02 = Firms.Where(n => (n.Name).IndexOf("Food") != -1);
            foreach (Firm f in Firms02) { Console.WriteLine(f); }

            Console.WriteLine(".3");
            var Firms03 = Firms.Where(n => n.BusinessProfile == "Marketing");
            foreach (Firm f in Firms03) { Console.WriteLine(f); }

            Console.WriteLine(".4");
            var Firms04 = Firms.Where(n => n.BusinessProfile == "Marketing" || n.BusinessProfile == "IT");
            foreach (Firm f in Firms04) { Console.WriteLine(f); }

            Console.WriteLine(".5");
            var Firms05 = Firms.Where(n => n.NumberOfEmploees > 100);
            foreach (Firm f in Firms05) { Console.WriteLine(f); }

            Console.WriteLine(".6");
            var Firms06 = Firms.Where(n => n.NumberOfEmploees >= 100 && n.NumberOfEmploees <= 300);
            foreach (Firm f in Firms06) { Console.WriteLine(f); }

            Console.WriteLine(".7");
            var Firms07 = Firms.Where(n => n.Adress == "London");
            foreach (Firm f in Firms07) { Console.WriteLine(f); }

            Console.WriteLine(".8");
            var Firms08 = Firms.Where(n => n.CEOSName == "White");
            foreach (Firm f in Firms08) { Console.WriteLine(f); }

            Console.WriteLine(".9");
            var Firms09 = Firms.Where(n => DateTime.Now - n.FoundingDate > new TimeSpan(365*2, 0, 0, 0));
            foreach (Firm f in Firms09) { Console.WriteLine(f); }

            Console.WriteLine(".10");
            var Firms10 = Firms.Where(n => DateTime.Now - n.FoundingDate > new TimeSpan(122, 0, 0, 0) 
                && DateTime.Now - n.FoundingDate < new TimeSpan(124, 0, 0, 0));
            foreach (Firm f in Firms10) { Console.WriteLine(f); }

            Console.WriteLine(".11");
            var Firms11 = Firms.Where(n => n.CEOSName == "Black" && n.Name.IndexOf("White") != -1);
            foreach (Firm f in Firms11) { Console.WriteLine(f); }
        }
    }
}
