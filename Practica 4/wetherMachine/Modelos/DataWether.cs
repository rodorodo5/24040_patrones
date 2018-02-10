using System;
using System.Collections.Generic;
using wetherMachine.Interfaces;

namespace wetherMachine.Modelos
{
    public class DataWether : ISends
    {
        public List<IObserver> listObs { get; set; }
        public int temp { get; set; }

        public void Add(IObserver observer)
        {
            listObs.Add(observer);
        }

        public void Notify()
        {
            for (int i = 0; i < listObs.Count; i++)
            {
                listObs[i].Update(10, 8, 5);
            }
        }

        public void Remove(IObserver observer)
        {
            listObs.Remove(observer);
        }

        public void MeasurementChanged()
        {
            Notify();
        }




    }
}
