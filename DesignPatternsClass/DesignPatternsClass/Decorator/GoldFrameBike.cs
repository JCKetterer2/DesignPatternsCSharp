using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Decorator
{
    public class GoldFrameBike : AbstractBikeOption
    {
        public GoldFrameBike(IBicycle bicycle)
            : base(bicycle)
        { }

        public override decimal Price
        {
            get { return decoratedBike.Price + 300.00m; }
        }
    }
}