using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public class Touring : AbstractRoadBike
    {
        public Touring()
            : this(BikeColor.Blue)
        {

        }

        public Touring(BikeColor color)
            : base(color)
        {

        }
    }
}
