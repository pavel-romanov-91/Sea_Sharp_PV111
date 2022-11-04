using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using static System.Console;
using System.IO;
using System.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Data;

namespace Home_Work_meeting_9
{
    class Exercise_1
    {
        static void Main(string[] args)
        {
            try
            {
                House house = new House();
                Team team = new Team();
                //string fulltext = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n", DateTime.Now);
                StreamWriter sw = new StreamWriter("F:\\Sea_Sharp_PV111\\Sea_Sharp_module_8\\bin\\DebugTest.txt");
                sw.WriteLine(house);
                sw.WriteLine(team.Name);
                Random r = new Random();
                for (int i = 0; i < 6; i++)
                {
                    team.w[r.Next(0, 3)].Build(house, team.t);
                }
                foreach (var a in team.t.report)
                {
                    sw.WriteLine(a);
                }
                team.t.Report();
                sw.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    team.w[r.Next(0, 3)].Build(house, team.t);
                }
                foreach (var a in team.t.report)
                {
                    sw.WriteLine(a);
                }
                team.t.Report();
                house.Paint(team.t);

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        interface IWorker
        {
            string Name
            {
                get;
            }
        }
        interface IPart
        {
            void Do(House house);
        }
        class Basement : IPart
        {
            public void Do(House house)
            {
                house.basement = new Basement();
            }
        }
        class Walls : IPart
        {
            public void Do(House house)
            {
                house.walls.Add(new Walls());
            }
        }
        class Door : IPart
        {
            public void Do(House house)
            {
                house.door = new Door();
            }
        }
        class Window : IPart
        {
            public void Do(House house)
            {
                house.window.Add(new Window());
            }
        }
        class Roof : IPart
        {
            public void Do(House house)
            {
                house.roof = new Roof();
            }
        }
        class House
        {
            public Basement basement;
            public List<Walls> walls;
            public List<Window> window;
            public Door door;
            public Roof roof;
            public void Paint(TeamLeader t)
            {
                if (t.report.Count == 11)
                {
                    string domik = @"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";

                    Console.WriteLine(domik);
                }
                else WriteLine("Дом еще на этапе строительства");
            }
        }
        class Team : IWorker
        {
            public TeamLeader t;
            public List<Worker> w;
            public string Name { get => "Фирма: Шараж строй инвест"; }

            public Team()
            {
                t = new TeamLeader("Дяткин");
                w = new List<Worker> { new Worker("Лукас"), new Worker("Питер"), new Worker("Иван"), new Worker("Петров") };
            }
        }
        class Worker : IWorker
        {
            string Name
            {
                get; set;
            }
            string IWorker.Name => Name;
            public Worker(string name)
            { Name = name; }
            public void Build(House house, TeamLeader t)
            {
                if (house.basement == null)
                {
                    Basement basement = new Basement();
                    basement.Do(house);
                    t.report.Add($"Работник {Name} Построил: ПОДВАЛ");
                }
                else if (house.walls == null || house.walls.Count < 4)
                {
                    if (house.walls == null) house.walls = new List<Walls>();
                    Walls wall = new Walls();
                    wall.Do(house);
                    t.report.Add($"Работник {Name} Построил: СТЕНУ {house.walls.Count}!");
                }
                else if (house.door == null)
                {
                    Door door = new Door();
                    door.Do(house);
                    t.report.Add($"Работник {Name} Построил: ДВЕРЬ");
                }
                else if (house.window == null || house.window.Count < 4)
                {
                    if (house.window == null) house.window = new List<Window>();
                    Window window = new Window();
                    window.Do(house);
                    t.report.Add($"Работник {Name} Построил: ОКНО {house.window.Count}!");
                }
                else if (house.roof == null)
                {
                    Roof roof = new Roof();
                    roof.Do(house);
                    t.report.Add($"Работник {Name} Построил: КРЫШУ!");

                }
            }
        }
        class TeamLeader : IWorker
        {
            string Name
            {
                get; set;
            }
            public List<string> report = new List<string>();
            string IWorker.Name => Name;
            public TeamLeader(string name)
            {
                Name = name;
            }
            public void Report()
            {
                double d = (report.Count / 11.0) * 100;
                WriteLine($"{(int)d} % ход выполнения работ!");
            }
        }
    }
}





//namespace Home_Work_meeting_10
//{
//    public class Sample
//    {
//        public static void Main()
//        {

//            // Создайте XmlDocument.
//            XmlDocument doc = new XmlDocument();
//            doc.LoadXml("<item><name>wrench</name></item>");

//            // Добавьте ценовой элемент.
//            XmlElement newElem = doc.CreateElement("price");
//            newElem.InnerText = "10.95";
//            doc.DocumentElement.AppendChild(newElem);

//            // Сохраните документ в файл.
//            doc.PreserveWhitespace = true;
//            doc.Save("data.xml");
//        }
//    }
//}












//namespace Home_Work_meeting_10
//{
//    class Exercise_1
//    {
//        static void Main(string[] args)
//        {
//            double rateUSDtoRUB = 72.95;
//            double rateRUBtoUSD = 73.30;
//            double rateEURtoRUB = 86.25;
//            double rateRUBtoEUR = 86.60;
//            double rateEURtoUSD = 1.18;
//            double compareSum = 0;
//            string changeFromStr, changeToStr;
//            string cycleCondition = "";
//            Console.WriteLine("Конвертер валют\n");
//            Console.Write("Введите количество у Вас рублей: ");
//            double rubN = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Введите количество у Вас долларов: ");
//            double usdN = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Введите количество у Вас евро: ");
//            double eurN = Convert.ToDouble(Console.ReadLine());
//            while (cycleCondition != "exit")
//            {
//                Console.Clear();
//                Console.SetCursorPosition(13, 0);
//                Console.WriteLine("Текущий курс валют:\n");
//                Console.WriteLine($"Продать USD: {rateUSDtoRUB} RUB, " + $"Купить USD: {rateRUBtoUSD} RUB\n" + $"Продать EUR: {rateEURtoRUB} RUB, " + $"Купить EUR: {rateRUBtoEUR} RUB\n");
//                Console.SetCursorPosition(13, 4);
//                Console.WriteLine($"Обменять EUR/USD: {rateEURtoUSD}\n");
//                Console.WriteLine($"У Вас {rubN} рублей, {usdN} долларов, {eurN} евро\n");
//                Console.Write("Какую валюту хотите поменять?\n" + "1-рубли, 2-доллары, 3-евро: ");
//                changeFromStr = Console.ReadLine();
//                if (changeFromStr == "1")compareSum = rubN;
//                else if (changeFromStr == "2")compareSum = usdN;
//                else if (changeFromStr == "3")compareSum = eurN;
//                else
//                    continue;
//                Console.Write("Введите сумму обмена: ");
//                double changeSum = Convert.ToDouble(Console.ReadLine());
//                if (changeSum > compareSum || changeSum == 0)continue;
//                Console.Write("Какую валюту хотите получить?\n" + "1-рубли, 2-доллары, 3-евро: ");
//                changeToStr = Console.ReadLine();
//                if (changeToStr == "1")
//                {
//                    if (changeFromStr == "2")
//                    {
//                        rubN += changeSum * rateUSDtoRUB;
//                        usdN -= changeSum;
//                    }
//                    else if (changeFromStr == "3")
//                    {
//                        rubN += changeSum * rateEURtoRUB;
//                        eurN -= changeSum;
//                    }
//                    else
//                    {
//                        continue;
//                    }
//                }
//                else if (changeToStr == "2")
//                {
//                    if (changeFromStr == "1")
//                    {
//                        usdN += changeSum / rateRUBtoUSD;
//                        rubN -= changeSum;
//                    }
//                    else if (changeFromStr == "3")
//                    {
//                        usdN += changeSum * rateEURtoUSD;
//                        eurN -= changeSum;
//                    }
//                    else
//                    {
//                        continue;
//                    }
//                }
//                else if (changeToStr == "3")
//                {
//                    if (changeFromStr == "1")
//                    {
//                        eurN += changeSum / rateRUBtoEUR;
//                        rubN -= changeSum;
//                    }
//                    else if (changeFromStr == "2")
//                    {
//                        eurN += changeSum / rateEURtoUSD;
//                        usdN -= changeSum;
//                    }
//                    else
//                    {
//                        continue;
//                    }
//                }
//                else
//                {
//                    continue;
//                }
//                Console.Clear();
//                Console.WriteLine($"Обмен произведён.\n" + $"У Вас {rubN} рублей, {usdN} долларов, {eurN} евро\n");
//                Console.WriteLine("Для продолжения нажмите Enter,\n" + "для выхода из программы введите exit и нажмите Enter");
//                cycleCondition = Console.ReadLine();
//            }
//        }

//    }

//}



