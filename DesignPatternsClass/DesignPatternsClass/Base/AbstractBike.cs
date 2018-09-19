using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public abstract class AbstractBike : IBicycle
    {
        private BikeColor _color;

        public BikeColor ColorType
        {
            get
            {
                return _color;
            }
        }


        public AbstractBike(BikeColor color)
        {
            this._color = color;
        }


        public virtual void Paint(BikeColor color)
        {
            this._color = color;
        }


        public override string ToString()
        {
            return this.GetType().Name + " Bicycle Color is " + _color;
        }
    }
}
