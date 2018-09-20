using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RoadBikeFrame : IBikeFrame
    {
        public virtual string BikeFrameParts
        {
            get { return "Frame parts for Road Bike."; }
        }
    }
}
