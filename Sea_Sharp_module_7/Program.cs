using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Home_Work_exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Sport_Car car = new Sport_Car();
            Bus bus = new Bus();
            Cargo_Car cargo_Car = new Cargo_Car();
            Automobile automobile = new Automobile();
            List<Thread> threads = new List<Thread>()
            {
                new Thread(cargo_Car.Ride),
                new Thread(car.Ride),
                new Thread(bus.Ride),
                new Thread(automobile.Ride)
            };
            foreach (Thread list in threads)
            {
                list.Start();
            }
            Console.ReadKey();
        }
    }
    abstract class Car
    {
        public delegate void Start();
        public delegate void Message();
        public event Message Display;

        public int My_Speed(Random rnd, int r1, int r2)
        {
            int speed;
            return speed = rnd.Next(r1, r2 + 1);
        }
        public void Win(string name)
        {
            Console.WriteLine($"{name} автомобиль прибыли к финишу");
        }
        public void Go(string name, int speed)
        {
            int distance = 0;
            Display += () => Win(name);
            for (int i = 0; i < 110; i += 10, distance += 10)
            {
                Thread.Sleep(speed);
                if (distance == 100) Display();
            }
        }
    }
    class Sport_Car : Car
    {
        public string Name = "Спортивный";
        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 500, 800));
        }
    }
    class Automobile : Car
    {
        public string Name = "Легковой";
        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 600, 900));
        }
    }
    class Cargo_Car : Car
    {
        public string Name = "Грузовой";
        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 700, 1000));
        }
    }

    class Bus : Car
    {
        public string Name = "Автобус";
        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 800, 1100));
        }
    }
}
