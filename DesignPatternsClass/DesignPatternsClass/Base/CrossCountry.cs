using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public class CrossCountry : AbstractMountainBike
    {
        public CrossCountry(IWheel wheel)
            : this(wheel, BikeColor.Red)
        {

        }

        public CrossCountry(IWheel wheel, BikeColor color)
            : base(wheel, color)
        {

        }
    }
}
