using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public class Downhill : AbstractMountainBike
    {
        public Downhill(IWheel wheel)
            : this(wheel, BikeColor.Red)
        {

        }

        public Downhill(IWheel wheel, BikeColor color)
            : base(wheel, color)
        {

        }
    }
}
