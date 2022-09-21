using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace mass
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine();
//            string selection = Console.ReadLine();
//            switch (selection)
//            {
//                case "1":
//                    one_dimensional_arrays();
//                    break;
//                case "2":
//                    two_dimensional_array();
//                    break;
//            }
//        }
//        public static void one_dimensional_arrays()  // одномерный массив из 5 элементов, который заполняется пользователем
//        {
//            int[] one;  //создаю одномерный массив
//            int[] A = new int[5]; //выделяю под него память для 5 элементов
//            for (int i=0;i<5;i++) //заполняю массив
//            {
//                A[i] = int.Parse(Console.ReadLine());
//                Array.Sort(A);
//                //нахожу максимальный элемент с помощью метода расширения Max 
//                int maxA = A[A.Length - 1];
//                Console.WriteLine("Maximal element:" + A);
//            }
//            int minA = A[5];
//            for (int i = 0; i < 5; i++) 
//            {
//                if (minA > A[i])
//                {
//                    minA = A[i];
//                }
//                Console.WriteLine("Minimal element:" + A);
//                Console.ReadLine();
//            }
//        }
//        public static void two_dimensional_array() // двумерный массив (3 строки, 4 стобца) дробных чисел
//        {
//            int[,] B = new int[3, 4]; // объявляю двумерный массив из 3 строк и 4 столбцов
//            Random ran = new Random();
//            // заполняю массив случайными числами с помощью циклов
//            for (int i = 0; i < 3; i++) 
//            {
//                for (int j = 0; j < 4; j++) 
//                {
//                    B[i, j] = ran.Next(1, 15);
//                    Console.Write("{0}\t", B[i, j]);
//                }
//                Console.WriteLine();
//            }
//            // поиск минимального значения в массиве В
//            int minB = B[3, 4];
//            for (int i = 0; i < 3; i++) 
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    if (minB > B[i, j]) 
//                    {
//                        minB = B[i, j];
//                    }
//                }
//                Console.WriteLine("Minimal element:" + minB);
//                Console.ReadLine();
//            }
//        }
//    }
//}


//namespace mass
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            int[,] massnumbers = new int[5, 5];
//            for (int i = 0; i < 5; i++)
//            {
//                for (int j = 0; j < 5; j++)
//                {
//                    massnumbers[i, j] = random.Next(-100, 100);
//                }
//            }
//            int min = massnumbers[0, 0];
//            int max = massnumbers[0, 0];
//            int sum = 0;
//            for (int i = 0; i < 5; i++)
//            {
//                for (int j = 0; j < 5; j++)
//                {
//                    if (min > massnumbers[i, j]) min = massnumbers[i, j];
//                    if (max < massnumbers[i, j]) max = massnumbers[i, j];
//                }
//            }
//            for (int i = 0; i < 5; i++)
//            {
//                for (int j = 0; j < 5; j++)
//                {
//                    if (massnumbers[i, j] >= min || massnumbers[i, j] <= max) sum += massnumbers[i, j];
//                }
//            }
//            for (int i = 0; i < 5; i++)
//            {
//                for (int j = 0; j < 5; j++)
//                {
//                    Console.Write("{0}\t", massnumbers[i, j]);
//                }
//                Console.Write("\n");
//            }
//            Console.WriteLine("Сумма элементов массива между минимальным и максимальным значением:{0}", sum);
//        }
//    }
//}


namespace mass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cipher = new CeasarCipher();
            Console.WriteLine("Напиши любой текст, я попробую его зашифровать!");
            var message = Console.ReadLine();
            Console.WriteLine("Введите ключ Шифра:");
            var secretkey = Convert.ToInt32(Console.ReadLine());
            var encryptedText = cipher.Encrypt(message, secretkey);
            Console.WriteLine("Зашифрованный текст: {0}", encryptedText);
            Console.WriteLine("Расшифрованный текст: {0}", cipher.Decrypt(encryptedText, secretkey));
        }
    }
}
class CeasarCipher
{
    const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    private string CodeEncode(string text, int k)
    {
        var fullAlphabet = alphabet + alphabet.ToLower();
        var LetterLength = fullAlphabet.Length;
        var cipherResult = "";
        for (int i = 0; i < text.Length; i++)
        {
            var c = text[i];
            var index = fullAlphabet.IndexOf(c);
            if (index < 0)
            {
                //если символ не знаком, оставляем его в исходном виде
                cipherResult += c.ToString();
            }
            else
            {
                var codeIndex = (LetterLength + index + k) % LetterLength;
                cipherResult += fullAlphabet[codeIndex];
            }
        }
        return cipherResult;
    }
    public string Encrypt(string Message, int key)
    {
        return CodeEncode(Message, key);
    }
    public string Decrypt(string encryptedMessage, int key)
    {
        return CodeEncode(encryptedMessage, -key);
    }
}