using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public class NarrowWheel : AbstractWheel
    {
        public NarrowWheel(int size) : base(size, false)
        {
            //not a wide wheel
        }
    }
}
