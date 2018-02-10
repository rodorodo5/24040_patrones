using System;
using wetherMachine.Modelos;

namespace wetherMachine.Interfaces
{
    public interface IObserver
    {
        //void Update(int temp, int hum, int pres);
        void Update(Observable obs, Object o);
    }
}
