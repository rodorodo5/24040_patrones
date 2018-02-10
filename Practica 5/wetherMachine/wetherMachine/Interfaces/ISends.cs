using System;
namespace wetherMachine.Interfaces
{
    public interface ISends
    {
        void Notify();
        void Remove(IObserver observer);
        void Add(IObserver observer);

    }
}
