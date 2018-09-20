using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public class Touring : AbstractRoadBike
    {
        public Touring(IWheel wheel)
            : this(wheel, BikeColor.Blue)
        {

        }

        public Touring(IWheel wheel, BikeColor color)
            : base(wheel, color)
        {

        }
    }
}
