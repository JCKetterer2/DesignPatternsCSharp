using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Decorator
{
    public class LeatherSeatBike : AbstractBikeOption
    {

        public LeatherSeatBike(IBicycle bicycle)
            : base(bicycle)
        { }

        public override decimal Price
        {
            get { return decoratedBike.Price + 40.00m; }
        }

    }
}