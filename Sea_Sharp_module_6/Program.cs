using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using static System.Console;

namespace Home_Work_exercise_6
{
    class Program
    {
        static void Main()
        {
            House house = new House();
            Team team = new Team();
            WriteLine(team.Name);
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                team.w[r.Next(0, 3)].Build(house, team.t);
            }
            foreach (var a in team.t.report)
            {
                WriteLine(a);
            }
            team.t.Report();
            WriteLine();
            for (int i = 0; i < 5; i++)
            {
                team.w[r.Next(0, 3)].Build(house, team.t);
            }
            foreach (var a in team.t.report)
            {
                WriteLine(a);
            }
            team.t.Report();
            house.Paint(team.t);
            ReadKey();
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





//namespace Class
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ManyFigure mf = new ManyFigure(3);
//            mf.DrawFigureSide();
//        }
//    }

//    abstract class GeometryFigure
//    {
//        protected int FigureSquare;
//        protected int FigurePreimeter;
//    }
//    class Triangle : GeometryFigure
//    {
//        public int Base { get; set; }
//        public int BaseSideAngle { get; set; }
//        public int SideLenght { get; set; }
//        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
//        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
//    }
//    class Quadro : GeometryFigure
//    {
//        public int Base { get; set; }
//        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
//        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
//    }
//    class Romb : GeometryFigure
//    {
//        public int Base { get; set; }
//        public int BaseSideAngle { get; set; }
//        public int SideLenght { get; set; }
//        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
//        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
//    }
//    class Rectangle : GeometryFigure
//    {
//        public int height { get; set; }
//        public int Base { get; set; }
//        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
//        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
//    }
//    class Paralellogramm : GeometryFigure
//    {
//        public int height { get; set; }
//        public int Base { get; set; }
//        public int BaseSideAngle { get; set; }
//        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
//        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
//    }
//    class Trapecia : GeometryFigure
//    {
//        public int height { get; set; }
//        public int Base { get; set; }
//        public int BaseSideAngle { get; set; }
//        public int SideLenght { get; set; }
//        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
//        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
//    }
//    class Circle : GeometryFigure
//    {
//        public int Radius { get; set; }
//        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
//        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
//    }
//    class Elipse : GeometryFigure
//    {
//        public int height { get; set; }
//        public int Base { get; set; }
//        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
//        public int Perimeter { get { return FigurePreimeter; } set { FigureSquare = value; } }
//    }
//    interface ISimpleNAngle
//    {
//        int height { get; set; }
//        int Base { get; set; }
//        int BaseSideAngle { get; set; }
//        int NumberSide { get; set; }
//        int SideLenght { get; set; }
//        int Area { get; set; }
//        int Perimeter { get; set; }
//    }
//    class ManyFigure : ISimpleNAngle
//    {
//        char[] drawchar = new char[11] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
//        public int height { get; set; }
//        public int Base { get; set; }
//        public int BaseSideAngle { get; set; }
//        public int NumberSide { get; set; }
//        public int SideLenght { get; set; }
//        public int Area { get; set; }
//        public int Perimeter { get; set; }

//        public ManyFigure(int numberSide)
//        {
//            NumberSide = numberSide;
//            double angle = 360 / NumberSide;

//        }
//        public void DrawFigureSide()
//        {

//            for (int i = 1; i <= drawchar.Length; i += 2)
//            {
//                int temp = (int)Math.Floor((double)(drawchar.Length / 2) - (int)Math.Floor((double)i) / 2);
//                for (int j = 0; j < i; j++)
//                {
//                    drawchar[temp + j] = '*';
//                }
//                Console.WriteLine(drawchar);
//            }
//        }

//        double FindArea()
//        {
//            return Area;
//        }
//    }
//}

