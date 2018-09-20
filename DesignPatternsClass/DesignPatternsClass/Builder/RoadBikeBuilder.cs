using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Builder
{
    public class RoadBikeBuilder : BikeBuilder
    {
        private AbstractRoadBike roadBikeInProgress;

        public override IBicycle Bicycle
        {
            get { return roadBikeInProgress; }
        }

        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this.roadBikeInProgress = roadBike;
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building Roadbike Handle Bars.");
        }

        public override void BuildStreetTires()
        {
            Console.WriteLine("Building Roadbike Street Tires");
        }
    }
}
