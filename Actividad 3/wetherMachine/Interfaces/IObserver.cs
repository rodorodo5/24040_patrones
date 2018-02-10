using System;
namespace wetherMachine.Interfaces
{
    public interface IObserver
    {
        void Update(int temp, int hum, int pres);
    }
}
