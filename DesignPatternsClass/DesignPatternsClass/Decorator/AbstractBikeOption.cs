using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Decorator
{
    public abstract class AbstractBikeOption : AbstractBike
    {
        protected internal IBicycle decoratedBike;

        public AbstractBikeOption(IBicycle bicycle)
            : base(bicycle.Wheel)
        {
            this.decoratedBike = bicycle;
        }
    }
}