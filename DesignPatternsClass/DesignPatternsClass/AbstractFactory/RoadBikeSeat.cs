using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RoadBikeSeat : IBikeSeat
    {
        public virtual string BikeSeatParts
        {
            get { return "Seat parts for Road Bike."; }
        }
    }
}
