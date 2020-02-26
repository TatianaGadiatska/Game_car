using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game_Car_Lib
{
    public interface ICar
    {
         string Name { get; set; }
        string Model { get; set; }
        int Speed { get; set; }
        double Time { get; set; }
    }
    public class Car : ICar
    {
       public string Name { get; set; }

       public  string Model { get; set; }
       public int Speed { get; set; }
       public double Time { get; set; }


        public Car()
        {
            Random rnd = new Random();
            Name = "V";
            Model = "Zaparic";
            Speed = rnd.Next(150, 171);
        }
       
    }
}
