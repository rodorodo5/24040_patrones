using System;
using System.Collections.Generic;
using rastreo.Interfaces;

namespace rastreo.Modules
{
    public class clientB : IObserver
    {
        List<string> providers = new List<string>();

        public void update(Observable obs, object o)
        {
            String msg = o.ToString();
            display(msg);
        }
        public void display(string msg)
        {
            Console.WriteLine("Client B recibio : " + msg);
        }


    }
}
