using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MountainBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreateBikeFrame()
        {
            return new MountainBikeFrame();
        }

        public override IBikeSeat CreateBikeSeat()
        {
            return new MountainBikeSeat();
        }
    }
}
