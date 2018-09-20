using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Builder
{
    public class RoadBikeDirector : BikeDirector
    {
        public override IBicycle Build(BikeBuilder builder)
        {
            builder.BuildHandleBars();
            builder.BuildStreetTires();

            return builder.Bicycle;
        }
    }
}
