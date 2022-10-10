using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_exercise_2
{
    class Program
    {
        static void Main(string[] ars)
        {
            Shop store = new Shop("ОЗОН ", " г. Москва ул. Ленина 143 ", "Онлайн продажи ", " +7-928-168-28-62 ", "OZON.ru", 34);
            Shop store2 = new Shop("ОЗОН ", " г. Москва ул. Ленина 143 ", "Онлайн продажи ", " +7-928-168-28-62 ", "OZON.ru", 54);
            store.GetShopInfo();
            int newstoreneam = 123;
            store.Square += newstoreneam;
            store.GetShopInfo();
            int storeneam = 23;
            store.Square -= newstoreneam;
            store.GetShopInfo();
            Console.WriteLine(store == store2);
            Shop shop3 = new Shop("", "", "", "", "", 0);
            shop3.AddShop(shop3);
            shop3.GetShopInfo();

        }
    }
    class Shop
    {
        string _name;
        string _address;
        string _description;
        string _telephone;
        string _mail;
        int _square;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        public string Telephone
        {
            get => _telephone;
            set => _telephone = value;
        }
        public string Mail
        {
            get => _mail;
            set => _mail = value;
        }
        public int Square
        {
            get => _square;
            set => _square = value;
        }
        public Shop(string name, string address, string description,
            string telephone, string mail, int square)
        {
            _name = name;
            _address = address;
            _description = description;
            _telephone = telephone;
            _mail = mail;
            _square = square;
        }
        public static int operator +(Shop square, int addsquare)
        {
            square._square += addsquare;
            return square._square;
        }
        public static int operator -(Shop square, int addsquare)
        {
            square._square -= addsquare;
            return square._square;
        }
        public static bool operator ==(Shop square, Shop othersquare)
        {
            return square._square == othersquare._square;
        }
        public static bool operator !=(Shop square, Shop othersquare)
        {
            return square._square != othersquare._square;
        }
        public static bool operator <(Shop square, Shop othersquare)
        {
            return square._square < othersquare._square;
        }
        public static bool operator >(Shop square, Shop othersquare)
        {
            return square._square > othersquare._square;
        }


        public Shop AddShop(Shop shop)
        {
            Console.Write("Введите название магазина:");
            string? name = Console.ReadLine();
            Console.Write("Введите адресс магазина:");
            string? address = Console.ReadLine();
            Console.Write("Введите профиль магазина:");
            string? description = Console.ReadLine();
            Console.Write("Введите номер телефона магазина:");
            string? telephone = Console.ReadLine();
            Console.Write("Введите эл.почту магазина:");
            string? mail = Console.ReadLine();
            Console.Write("Введите площадь магазина:");
            int area = Int32.Parse(Console.ReadLine());
            return shop;
        }
        public override string ToString()
        {
            return " Название магазин: " + Name + ";\n Адресс магазина: " + Address + ";\n Описание магазина: " + Description + ";\n Номер магазина: " + Telephone + ";\n Адресс эл.почты магазина: " + Mail + ";\n Площадь магазина: " + Square.ToString() + "Квадратные метры: ";
        }
        public void GetShopInfo()
        {
            Console.WriteLine(ToString());
        }
    }

}














//using System;

//namespace Home_Work_exercise_1
//{
//    class Program
//    {
//        static void Main(string[] ars)
//        {

//            Neam neam = new Neam("Увеличение штата: 32");
//            Console.WriteLine($"Штат {neam.Name}");
//            neam += 23;



//            Console.WriteLine("Название разработки: ");
//            string? name = Console.ReadLine();
//            string? developer = Console.ReadLine();
//            Data_Input d1 = new Data_Input(name, developer);

//            Console.WriteLine("\nФ.И.О.: ");
//            string name1 = Console.ReadLine();
//            string fio = Console.ReadLine();
//            FIO d2 = new FIO(name1, fio);

//            Console.Clear();
//            Console.WriteLine(d1.GetInfo());
//            Console.WriteLine(d2.GetInfo());

//            var web_site = new Neam();
//            Console.WriteLine(web_site.Name);
//            var path_site = new Path_Site();
//            Console.WriteLine(path_site.Path);
//            var description_site = new Description_Site();
//            Console.WriteLine(description_site.Site);
//            var ip = new Ip();
//            Console.WriteLine(ip.ip);
//        }

//    }
//    class Neam
//    {

//        public Neam()
//        {
//            Name = "\nНазвание журнала: VOGUE\n" +
//                "\nКоличество сотрудников в журнале: 200 человек\n";
//        }
//        public Neam(string name)
//        {
//            Name = name;
//        }
//        public string Name { get; set; }

//        public static Neam operator +(Neam a, int b)
//        {
//            a.Name += b;
//            return a;
//        }
//        public static int operator +(int b, Neam a)
//        {
//            return b + Neam.a;
//        }


//        public override string ToString()
//        {
//            return Name;
//        }
//        public void GetNeamInfo()
//        {
//            Console.WriteLine(ToString());
//        }


//    }

//    class Path_Site
//    {
//        public Path_Site()
//        {
//            Path = "Год основания журнала: 1991 г.\n" +
//                "\nОписание Журнала: На сайте vogue.ru могут содержаться упоминания\nи ссылки на Facebook и Instagram, ресурсы принадлежащие компании Meta,  деятельность\nкоторой запрещена в РФ. При этом, вся информация и ссылки на Facebook и Instagram\nразмещены до запрета деятельности Meta на территории России. На сайте vogue.ru отсутствуют\nзапрещенные в связи с их содержанием материалы и/или ссылки на такие материалы.\n";
//        }
//        public Path_Site(string path)
//        {
//            Path = path;
//        }
//        public string Path { get; set; }
//        public override string ToString()
//        {
//            return Path;
//        }
//    }
//    class Description_Site
//    {
//        public Description_Site()
//        {
//            Site = "Контактный телефон: +7-928-168-28-62\n";
//        }
//        public Description_Site(string site)
//        {
//            Site = site;
//        }
//        public string Site { get; set; }
//        public override string ToString()
//        {
//            return Site;
//        }
//    }
//    class Ip
//    {
//        public Ip()
//        {
//            ip = "Контактный e-mail: pavel-romanov-91@mail.ru";
//        }
//        public Ip(string Ip)
//        {
//            Ip = ip;
//        }
//        public string ip { get; set; }
//        public override string ToString()
//        {
//            return ip;
//        }
//    }

//    class Data_Input
//    {
//        string name, developer;
//        public Data_Input(string name, string developer)
//        {
//            this.name = name;
//            this.developer = developer;
//        }
//        public string GetInfo()
//        {
//            return string.Format(name, developer);
//        }
//    }
//    class FIO
//    {
//        string name1, fio;
//        public FIO(string name, string fio)
//        {
//            this.name1 = name;
//            this.fio = fio;
//        }
//        public string GetInfo()
//        {
//            return string.Format(name1, fio);
//        }
//    }
//    class Amount
//    {
//        string name2, amount;
//        public Amount(string name2, string amount)
//        {
//            this.name2 = name2;
//            this.amount = amount;
//        }
//        public string GetInfo()
//        {
//            return string.Format(name2, amount);
//        }
//    }



//}










//using System.Collections;
//using System.Collections.Generic;

//namespace BookShop_exercise_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Book> list = new List<Book>();
//            list.Add(new Book("Оно", "America", "Horror", "Stephen King", 700, 1995, 1000));
//            list.Add(new Book("Оно2", "America", "Horror", "Stephen King", 700, 1995, 1000));
//            list.Add(new Book("Оно3", "America", "Horror", "Stephen King", 700, 1995, 1000));
//            Shop sh = new Shop(Properties.Resources.ShopName, "ТЦ \"Рассвет\"", list);
//            sh.GetShopName();
//            Command.HelpCommand();
//            while (true)
//            {
//                Console.Write("Введите новую команду: ");
//                string command = Console.ReadLine();
//                switch (command)
//                {
//                    case "help": Command.HelpCommand(); break;
//                    case "addbook": sh.AddABook(Command.AddBookCommand()); sh.GetAllBooks(); break;
//                    case "removebook": sh.DeleteBookByIndex(Command.RemoveBookCommand()); sh.GetAllBooks(); break;
//                    case "removebookname": sh.DeleteBookByName(Command.RemoveBookCommandName()); sh.GetAllBooks(); break;
//                    case "getbooks": Command.GetAllBookCommand(); sh.GetAllBooks(); break;
//                    case "clear": Console.Clear(); break;
//                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Не удалось распознать команду. Наберите help для списка команд"); Console.ForegroundColor = ConsoleColor.White; break;
//                }

//            }
//        }
//    }
//    class Book : IEnumerable, IComparable, IBook
//    {
//        public string Name { get; set; }
//        public string Publishing { get; set; }
//        public string Genre { get; set; }
//        public string Author { get; set; }
//        public int NumberPages { get; set; }
//        public int YearOfPublishing { get; set; }
//        public int Price { get; set; }

//        public Book(string name, string publishing, string genre, string author, int numberpages, int yearofpublishing, int price)
//        {
//            Name = name;
//            Publishing = publishing;
//            Genre = genre;
//            Author = author;
//            NumberPages = numberpages;
//            YearOfPublishing = yearofpublishing;
//            Price = price;
//        }
//        public override string ToString()
//        {
//            return Name + " " + Publishing + " " + Genre + " " + Author + " " + NumberPages.ToString() + " " +
//                YearOfPublishing.ToString() + " " + Price.ToString();
//        }

//        public IEnumerator GetEnumerator()
//        {
//            return ((IEnumerable)Name).GetEnumerator();
//        }

//        public int CompareTo(object? obj)
//        {
//            return Name.CompareTo((string?)obj);
//        }

//        public int Compare(object? obj, object? obj2)
//        {
//            return ((Book)obj).Name.CompareTo((string?)obj2);
//        }
//    }

//    class Shop : IShop
//    {
//        List<Book> Books;
//        public string Name { get; set; }
//        public string Address { get; set; }
//        public Shop(string name, string address, List<Book> books)
//        {
//            Name = name;
//            Address = address;
//            Books = books;
//        }
//        public void GetShopName()
//        {
//            Console.WriteLine("Добро пожаловать в {0} по адресу {1}", Name, Address);
//        }
//        public void GetAllBooks()
//        {
//            int index = 1;
//            foreach (Book book in Books)
//            {
//                Console.WriteLine("Индекс: {0} {1}", index, book);
//                index++;
//            }
//        }
//        public void AddABook(Book book)
//        {
//            Books.Add(book);
//        }
//        public void DeleteBookByName(string name)
//        {
//            int index = -1;
//            foreach (Book book in Books)
//            {
//                if (book.CompareTo(name) == 0) index = Books.IndexOf(book);
//            }
//            if (index >= 0) Books.RemoveAt(index);
//        }
//        public void DeleteBookByIndex(int index)
//        {
//            Books.RemoveAt(index - 1);
//        }
//    }

//    class Command
//    {
//        public static void HelpCommand()
//        {
//            Console.WriteLine("Используйте addbook для добавления книги, removebook для удаления книги по индексу, removebookname для удаления книги по имени,getbooks для списка книг, clear для очистки консоли:");
//        }
//        public static Book AddBookCommand()
//        {
//            Book book;
//            Console.Write("Введите имя книги: ");
//            string name = Console.ReadLine();
//            Console.Write("Введите издательство книги: ");
//            string publishing = Console.ReadLine();
//            Console.Write("Введите жанр книги: ");
//            string genre = Console.ReadLine();
//            Console.Write("Введите автора книги: ");
//            string author = Console.ReadLine();
//            Console.Write("Введите количество страниц книги: ");
//            int numberpage = Int32.Parse(Console.ReadLine());
//            Console.Write("Введите год издания книги: ");
//            int yearofpublishing = Int32.Parse(Console.ReadLine());
//            Console.Write("Введите цену книги: ");
//            int price = Int32.Parse(Console.ReadLine());
//            book = new Book(name, publishing, genre, author, numberpage, yearofpublishing, price);
//            return book;
//        }
//        public static int RemoveBookCommand()
//        {
//            Console.WriteLine("Укажите индекс удаляемой книги:");
//            return Int32.Parse(Console.ReadLine());

//        }
//        public static string RemoveBookCommandName()
//        {
//            Console.WriteLine("Укажите имя удаляемой книги");
//            return Console.ReadLine();
//        }
//        public static void GetAllBookCommand()
//        {
//            Console.WriteLine("Список книг в магазине:");
//        }
//    }

//    interface IShop
//    {

//        string Name { get; set; }
//        string Address { get; set; }
//        public void GetShopName();

//        public void GetAllBooks();
//        public void AddABook(Book book);
//        public void DeleteBookByName(string name);
//        public void DeleteBookByIndex(int index);
//    }

//    interface IBook
//    {
//        public string Name { get; set; }
//        public string Publishing { get; set; }
//        public string Genre { get; set; }
//        public string Author { get; set; }
//        public int NumberPages { get; set; }
//        public int YearOfPublishing { get; set; }
//        public int Price { get; set; }
//    }
//}




