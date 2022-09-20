// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Hello, World!");

Console.WriteLine("It easy to win forgiveness for being wrong;\nbeng right is what gets you into real trouble.\nBjarne Stroustrup\n");

//int[] massive = new int[5];
//int summary = 0, multiply = 1, max, min;
//string line = Console.ReadLine();
//massive[0] = Int32.Parse(line);
//massive[0] = Int32.Parse(Console.ReadLine());
int n = 5;
String[] list = new String[n];
int[] massive = new int[5];
int summary = 0, multiply = 1, max, min;
min = massive[0];
max = massive[0];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Введите число для иендекса {0}, i");
    massive[i] = Int32.Parse(Console.ReadLine());
}
min = massive[0]; max = massive[0];
for (int i = massive.Length - 1; i > 0; i--)
{
    summary += massive[i];
    multiply *= massive[i];
    if (min < massive[i]) { min = massive[i]; }
    if (min > massive[i]) { max = massive[i]; }

}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(multiply);


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Введите число 1 до 100: ");
    massive[i] = Int32.Parse(Console.ReadLine());
}
Enumerable.Range(1, 5).ToList().ForEach(num => Console.WriteLine
($"{num} {(num % 3 == 0 ? "Fizz" : "")}{(num % 5 == 0 ? "Buzz" : "")}"));

Random random = new Random();
int counter = 0;
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = random.Next(100);
}
Console.WriteLine("Введите число от 0 до 1000. Будут показаны все элементы меньше вашего числа.");
try
{
    string number = Console.ReadLine();
    int z = Int32.Parse(number);
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < z || massive[i] == 0)
        {
            counter++;
        }
    }
    Console.WriteLine("чисел меньше {0} найдено {1} штук", number, counter);
}
catch (Exception)
{
    Console.WriteLine("Только числа!");
}

int[] massive2 = new int[12] { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
string numbersText = "";
StringBuilder sb = new StringBuilder();
for (int i = 0; i < massive2.Length; i++)
{
    sb.Append(massive2[i]);
}
numbersText = sb.ToString();
Console.WriteLine("Массив для поиска числового вхождения: \n" + numbersText);
string searchText = Console.ReadLine();
for (int i = 0; i < numbersText.Length; i++)
{
    if (numbersText.Contains(searchText))
    {
        int indexContain = numbersText.IndexOf(searchText);
        counter++;
        numbersText = numbersText.Remove(0, indexContain + 1);
    }
    else
    {
        Console.WriteLine("Искомой подстроки не обнаружено!");
        break;
    }
}
Console.WriteLine("Искомая подстрока найдена{0} раз(а) ", counter);