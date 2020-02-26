using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game_Car_Lib
{
    class Game
    {
        private LinkedList<Car> cars = new LinkedList<Car>();
        public static int count_car = 0;
        public int Distans { get; set; }
        public void Add_Car(Car car)
        {
                count_car++;
                cars.AddLast(car);
        }

        public void Start_Game()
        {
            
            foreach (Car item in cars)
            {
                
            }
        }


        public void Metod_End()
        {

        }
    }
}
