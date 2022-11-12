//using System;
//using System.IO; 
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;

//namespace Home_Work_meeting_12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string unicodeString = "(\u03a0)";

//            Attribute b1 = new Attribute("Атрибут", "Романов П.В.", 1991, 1);

//            BinaryFormatter binaryFormat = new BinaryFormatter();

//            try
//            {
//            Encoding ascii = Encoding.ASCII;
//            Encoding unicode = Encoding.Unicode;
//            byte[] unicodeBytes = unicode.GetBytes(unicodeString);
//            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
//            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
//            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
//            string asciiString = new string(asciiChars);

//                using (Stream fOut = File.Create("Attribute.ini"))
//                {
//                    binaryFormat.Serialize(fOut, b1);
//                }
//                Console.WriteLine("сериализация выполнена.", asciiString);


//                using (Stream fIn = File.OpenRead("Attribute.ini"))
//                {
//                    Attribute b2;
//                    b2 = (Attribute)binaryFormat.Deserialize(fIn);
//                    b2.Print("Экземпляр b2:");
//                    Console.WriteLine("десериализация выполнена.", asciiString);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }

//            Console.ReadKey();
//        }
//    }
//    [Serializable]
//    struct Attribute
//    {
//        public string attribute;
//        public string author;
//        public int year;

//        [NonSerialized]
//        public int number; 
//        public Attribute(string attribute, string author, int year, int number)
//        {
//            this.attribute = attribute;
//            this.author = author;
//            this.year = year;
//            this.number = number;
//        }
//        public void Print(string msg)
//        {
//            Console.WriteLine(msg);
//            Console.WriteLine("Автор: " + author);
//            Console.WriteLine("Атрибут: " + attribute);
//            Console.WriteLine("Год: " + year);
//        }
//    }
//}

//[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
//class MyAttribute : System.Attribute
//{
//    private readonly string name;
//    public string Name
//    {
//        get { return name; }
//    }
//    public MyAttribute(string name)
//    {
//        this.name = name;
//    }
//    public int Age { get; set; }
//}


using System;

namespace Home_Work_meeting_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Type tp = typeof(MyClass);
            object[] attr = tp.GetCustomAttributes(false);
            Console.WriteLine("Атрибуты класса:");
            foreach (object o in attr)
            {
                Console.WriteLine(o.GetType().Name);
            }
            Console.ReadKey();
        }
    }
    class MyClassCommentAttribute : Attribute
    {
        private string comment; 
        public MyClassCommentAttribute(string _comment)
        {
            comment = _comment;
        }
    }
    [MyClassCommentAttribute("мой класс.")]
    class MyClass
    {
       
    }

    
}