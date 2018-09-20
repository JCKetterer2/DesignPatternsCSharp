using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MountainBikeFrame : IBikeFrame
    {
        public virtual string BikeFrameParts
        {
            get { return "Frame parts for Mountain Bike."; }
        }
    }
}
