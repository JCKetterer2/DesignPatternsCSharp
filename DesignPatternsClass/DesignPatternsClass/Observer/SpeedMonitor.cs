using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class SpeedMonitor
    {
        public const int SpeedToAlert = 30;

        public SpeedMonitor(Speedometer speed)
        {
            speed.ValueChanged += ValueHasChanged;
        }

        private void ValueHasChanged(object sender, EventArgs e)
        {
            Speedometer mySpeed = (Speedometer)sender;

            if(mySpeed.CurrentSpeed > SpeedToAlert)
            {
                Console.WriteLine("** ALERT ** Riding too fast! (" + mySpeed.CurrentSpeed + ")");
            }
            else
            {
                Console.WriteLine("... nice and steady ... (" + mySpeed.CurrentSpeed + ")");
            }
        }
    }
}
