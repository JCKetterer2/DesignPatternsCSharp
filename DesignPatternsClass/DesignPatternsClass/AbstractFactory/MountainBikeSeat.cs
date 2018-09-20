using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MountainBikeSeat : IBikeSeat
    {
        public virtual string BikeSeatParts
        {
            get { return "Seat parts for Mountain Bike."; }
        }
    }
}
