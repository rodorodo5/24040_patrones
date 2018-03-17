using System;
using System.Collections.Generic;
using rastreo.Interfaces;

namespace rastreo.Modules
{
    public abstract class Observable
    {
        private Boolean changed = false;
        List<IObserver> observers;

        public Observable()
        {
            this.observers = new List<IObserver>();
        }
        public void add(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void notify(Object o)
        {
            foreach (IObserver observer in observers)
            {
                observer.update(this, o);
            }
        }

        public void setChanged(bool b)
        {
            this.changed = b;
        }
    }
}
