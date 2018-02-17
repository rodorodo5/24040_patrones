using System;
using System.Timers;

namespace rastreo.Modules
{
    public class Fedex :Observable
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        string msg = "Update de Fedex";
        public Fedex()
        {
            timer.Elapsed += new ElapsedEventHandler(dailyUpdate);
            timer.Interval = 4000;
            timer.Enabled = true;
        }

        public void dailyUpdate(object source, ElapsedEventArgs e)
        {
            notify(msg);
        }
    }
}
