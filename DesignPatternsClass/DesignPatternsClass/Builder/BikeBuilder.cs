using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Builder
{
    public abstract class BikeBuilder
    {
        public abstract IBicycle Bicycle { get; }

        public virtual void BuildStreetTires() { }

        public virtual void BuildWideTires() { }

        public virtual void BuildHandleBars() { }
    }
}
