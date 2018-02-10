using System;
using System.Collections.Generic;
using System.Numerics;
using wetherMachine.Interfaces;

namespace wetherMachine.Modelos
{
    public class Observable
    {
        private Boolean changed = false;
        List<IObserver> observers;

        public Observable()
        {
            this.observers = new List<IObserver>();
        }
        public void add(IObserver observer){
            this.observers.Remove(observer);
        }

        public void notify(Object o ){
            foreach (IObserver observer in observers)
            {
                observer.Update(this, o);
            }
        }

        public void setChanged(bool b){
            this.changed = b;
        }

    }
}
