using System;
using rastreo.Modules;

namespace rastreo.Interfaces
{
    public interface IObserver
    {
        void update(Observable obs, Object o);
    }
}
