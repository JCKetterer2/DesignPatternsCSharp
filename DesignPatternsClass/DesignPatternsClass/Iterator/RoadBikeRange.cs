using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Iterator
{
    public class RoadBikeRange
    {
        private IList<IBicycle> bicycles;

        //LIST
        public RoadBikeRange()
        {
            bicycles = new List<IBicycle>();

            //define the range of models
            bicycles.Add(new Touring(new NarrowWheel(24)));
            bicycles.Add(new Touring(new NarrowWheel(22)));
            bicycles.Add(new Touring(new NarrowWheel(26)));
            bicycles.Add(new Vintage(new NarrowWheel(24)));
            bicycles.Add(new Vintage(new NarrowWheel(22)));
        }

        public virtual IList<IBicycle> Range
        {
            get { return bicycles; }
        }

        public virtual IEnumerator<IBicycle> GetEnumerator()
        {
            return ((IEnumerable<IBicycle>)bicycles).GetEnumerator();
        }
    }
}
