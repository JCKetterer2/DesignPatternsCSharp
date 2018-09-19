using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public class Downhill : AbstractMountainBike
    {
        public Downhill()
            : this(BikeColor.Red)
        {

        }

        public Downhill(BikeColor color)
            : base(color)
        {

        }
    }
}
