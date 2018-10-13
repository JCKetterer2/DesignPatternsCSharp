using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public class Vintage : AbstractRoadBike
    {
        public Vintage(IWheel wheel)
            : this(wheel, BikeColor.Blue)
        {

        }

        public Vintage(IWheel wheel, BikeColor color)
            : base(wheel, color)
        {

        }

        public override decimal Price
        {
            get { return 600.00m; }
        }
    }
}
