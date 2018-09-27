using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class GearBox
    {
        public GearBox(Speedometer speed)
        {
            speed.ValueChanged += ValueHasChanged;
        }

        private void ValueHasChanged(object sender, EventArgs e)
        {
            Speedometer mySpeed = (Speedometer)sender;

            if (mySpeed.CurrentSpeed <= 10)
            {
                Console.WriteLine("Now in easy gear");
            }
            else if(mySpeed.CurrentSpeed <= 20)
            {
                Console.WriteLine("Now in 2nd gear");
            }
            else if(mySpeed.CurrentSpeed <= 25)
            {
                Console.WriteLine("Now in 3rd gear");
            }
            else if(mySpeed.CurrentSpeed <= 30)
            {
                Console.WriteLine("Now in 4th gear");
            }
        }
    }
}
