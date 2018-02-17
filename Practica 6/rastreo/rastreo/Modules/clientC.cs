﻿using System;
using System.Collections.Generic;
using rastreo.Interfaces;

namespace rastreo.Modules
{
    public class clientC : IObserver
    {
        List<string> providers = new List<string>();

        public void update(Observable obs, object o)
        {
            String msg = o.ToString();
            display(msg);
        }
        public void display(string msg)
        {
            Console.WriteLine("Client C recibio : " + msg);
        }

    }
}
