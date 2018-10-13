using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Decorator
{
    public class WhiteTiresBike : AbstractBikeOption
    {

        public WhiteTiresBike(IBicycle bicycle)
            : base(bicycle)
        { }

        public override decimal Price
        {
            get { return decoratedBike.Price + 80.00m; }
        }

    }
}