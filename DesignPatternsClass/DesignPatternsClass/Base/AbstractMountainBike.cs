using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public abstract class AbstractMountainBike : AbstractBike
    {
        public AbstractMountainBike(IWheel wheel)
            : this(wheel, BikeColor.Black)
        {

        }

        public AbstractMountainBike(IWheel wheel, BikeColor color)
            : base(wheel, color)
        {

        }

    }
}
