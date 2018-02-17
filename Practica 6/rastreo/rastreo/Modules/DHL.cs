using System;
using System.Threading;
using System.Timers;

namespace rastreo.Modules
{
    public class DHL : Observable{
        string msg = "Update de DHL";
        System.Timers.Timer timer = new System.Timers.Timer();
        public DHL(){
            timer.Elapsed += new ElapsedEventHandler(dailyUpdate);
            timer.Interval = 3000;
            timer.Enabled = true;
        }

        public void dailyUpdate(object source , ElapsedEventArgs e){
            notify(msg);
        }
    }
}
