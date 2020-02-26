using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            g.Add_Car(new Car());
            Thread.Sleep(1000);
            g.Add_Car(new Car("Vac", "BMV"));
            Thread.Sleep(1000);
            g.Add_Car(new Car("Ja", "Volvo"));

            g.Start_Cars();
            Thread.Sleep(4000);
            g.GettTime();
            g.GetBastTime();

            Console.ReadKey();
        }
    }
    public interface ICar
    {
        string Name { get; set; }
        string Model { get; set; }
        int Speed { get; set; }
    }
    public class Car : ICar
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public double Time { get; set; }

        public Car()
        {
            Random rnd = new Random();
            Name = "V";
            Model = "Zaparic";
            Speed = rnd.Next(150, 171);
        }

        public Car(string n, string m)
        {
            Random rnd = new Random();
            Name = n;
            Model = m;
            Speed = rnd.Next(150, 171);
        }
    }

    class Game
    {
        private LinkedList<Car> cars = new LinkedList<Car>();
        public static int count_car = 0;
        public int Distans { get; set; }

        public Game() { Distans = 100; }


        public void Add_Car(Car car)
        {
            
          
                count_car++;
                cars.AddLast(car);
           
        }
        public void Trek(object car)
        {
            Car temp = (Car)car;
            while (Distans >= 0)
            {
                Distans -= temp.Speed/100;
                Thread.Sleep(100);  
                Console.WriteLine(temp.Name + "    " + Distans + "    " + temp.Speed + "    " + (double)100/temp.Speed);
            }
        }

        public void Start_Cars()
        {
            foreach (object item in cars)
            {
                ParameterizedThreadStart pth = new ParameterizedThreadStart(Trek);
                Thread th = new Thread(pth);
                th.Start(item);
                
           }
            

        }
        public void GettTime()
        {
            Console.Clear();
            foreach (Car item in cars)
            {
                item.Time = (double)100 / item.Speed;
                Console.WriteLine($"{item.Name} time is {item.Time}");
            }
        }

        public double GetBastTime()
        {
            double min_time = cars.Select(car => car.Time).Min();

            Console.WriteLine(min_time);
            return min_time;
        }
    }
}
