using System;
using System.Collections.Generic;
using wetherMachine.Interfaces;

namespace wetherMachine.Modelos
{
    public class DataWether : Observable
    {
        public int Temp { get; set; }
        public int Pres { get; set; }
        public int Hum { get; set; }

     
        public void MeasurementChanged()
        {
            Notify(this);
        }

        void setMeasurements (int temp , int pres, int hum){
            this.Temp = temp;
            this.Hum = hum;
            this.Pres = pres;
        }




    }
}
