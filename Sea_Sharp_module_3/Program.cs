//namespace Home_Work_exercise_1
//{
//    public class Program
//    {
//        private string qtySymbols;
//        static void Main(string[] args)
//        {
//            Console.WriteLine("*");
//            Console.WriteLine("Введите ширину квадрата: ");
//            Console.WriteLine();
//            int qtySymbols = int.Parse(Console.ReadLine());
//            Console.WriteLine();
//            LineOutput(qtySymbols);
//            Console.ReadLine();
//        }
//        static void LineOutput(int qtySymbols)
//        {
//            if (qtySymbols > 0)
//                Console.WriteLine(new string('*', qtySymbols));
//            for (int i = 0; i < qtySymbols - 2; i++)
//                Console.WriteLine("*" + new string(' ', qtySymbols - 2) + "*");
//            if (qtySymbols > 0)
//                Console.WriteLine(new string('*', qtySymbols));
//        }
//    }
//}


//namespace Home_Work_exercise_2
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите число на проверку:\n");
//            string name = Console.ReadLine();
//            string revers = string.Empty;
//            for (int i = name.Length - 1; i >= 0; i--)
//            {
//                revers += name[i];
//            }
//            if (name == revers)
//            {
//                Console.WriteLine("Число является палендромом: ");
//            }
//            else
//            {
//                Console.WriteLine("Число не является палиндромом: ");
//            }
//        }

//    }
//}



//namespace Home_Work_exercise_3
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            int[] intArray = new int[] { 1, 2, 6, -1, 88, 7, 6 };
//            Console.WriteLine("Оригенальный массив: ");
//            foreach (int i in intArray)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine("Массив отсартированный: ");
//            Array.Sort(intArray);
//            foreach (int i in intArray)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine("Массив отссортированный в обратную: ");
//            Array.Reverse(intArray);
//            foreach (int i in intArray)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//}


namespace Home_Work_exercise_4
{
    class TestPerson
    {
        static void Main(string[] ars)
        {
            Console.WriteLine("Название разработки: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Ф.И.О. : ");
            string? developer = Console.ReadLine();
            Data_Input d1 = new Data_Input(name, developer);
            Console.WriteLine(d1.GetInfo());
            var web_site = new Neam();
            Console.WriteLine(web_site.Name);
            var path_site = new Path_Site();
            Console.WriteLine(path_site.Path);
            var description_site = new Description_Site();
            Console.WriteLine(description_site.Site);
            var ip = new Ip();
            Console.WriteLine(ip.ip);
        }
    }
    public class Neam
    {
         public Neam()
        {
            Name = "Название сайта: journal.top-academy.ru";
        }
         public Neam(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class Path_Site
    {
        public Path_Site()
        {
            Path = "Путь к сайту: https://journal.top-academy.ru/ru/main/homework/page/index";
        }
        public Path_Site(string path)
        {
            Path = path;
        }
        public string Path { get; set; }
        public override string ToString()
        {
            return Path;
        }
    }
    public class Description_Site
    {
        public Description_Site()
        {
            Site = "Описание сайта: Дневник обучающего";
        }
        public Description_Site(string site)
        {
            Site = site;
        }
        public string Site { get; set; }
        public override string ToString()
        {
            return Site;
        }
    }
    public class Ip
    {
        public Ip()
        {
            ip = "ip адрес сайта: 46.148.233.24";
        }
        public Ip(string Ip)
        {
            Ip = ip;
        }
        public string ip { get; set; }
        public override string ToString()
        {
            return ip;
        }
    }
    class Data_Input
    {
        string name, developer;
        public Data_Input(string name, string developer)
        {
            this.name = name;
            this.developer = developer;
        }
    public string GetInfo()
        {
            return string.Format("Название разработки: , Ф.И.О. :", name, developer);
        }
    }
}