using System;
using System.Timers;

namespace rastreo.Modules
{
    public class CorreoMexico :Observable
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        string msg = "Update de Correo de Mexico";
        public CorreoMexico()
        {
            timer.Elapsed += new ElapsedEventHandler(dailyUpdate);
            timer.Interval = 7000;
            timer.Enabled = true;
        }

        public void dailyUpdate(object source, ElapsedEventArgs e)
        {
            notify(msg);
        }

    }
}
