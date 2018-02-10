using System;
using wetherMachine.Interfaces;

namespace wetherMachine.Modelos
{
    public class Disp_a : IObserver, IDisplays
    {

        public int Temp { get; set; }
        public int Hum { get; set; }
        public int Pres { get; set; }


        public void Displays()
        {
            Console.WriteLine("Temperature" + Temp);
            Console.WriteLine("Humedity" + Hum);
            Console.WriteLine("Pressure"+ Pres);
        }

        public void Update(int temp, int hum, int pres)
        {
            Temp = temp;
            Hum = hum;
            Pres = pres;
        }

        public void Update(Observable obs, object o)
        {
            DataWether wd = (DataWether)o;
        }
    }
}
