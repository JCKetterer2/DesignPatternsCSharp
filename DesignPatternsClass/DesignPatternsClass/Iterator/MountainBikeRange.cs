using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Iterator
{
    public class MountainBikeRange
    {
        private IBicycle[] bicycles;

        //ARRAY
        public MountainBikeRange()
        {
            bicycles = new IBicycle[4];

            //Define the range of Mountain Bikes available
            bicycles[0] = new Downhill(new WideWheel(22));
            bicycles[1] = new Downhill(new WideWheel(24));
            bicycles[2] = new CrossCountry(new WideWheel(24));
            bicycles[3] = new CrossCountry(new WideWheel(26));
        }

        public virtual IBicycle[] Range
        {
            get { return bicycles; }
        }

        public virtual IEnumerator<IBicycle> GetEnumerator()
        {
            return ((IEnumerable<IBicycle>)bicycles).GetEnumerator();
        }
    }
}
