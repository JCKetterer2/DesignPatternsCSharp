using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Decorator
{
    public class CustomGripBike : AbstractBikeOption
    {
        public CustomGripBike(IBicycle bicycle)
            : base(bicycle)
        { }

        public override decimal Price
        {
            get { return decoratedBike.Price + 20.00m; }
        }

    }
}