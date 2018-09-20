using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public class WideWheel : AbstractWheel
    {
        public WideWheel(int size) : base(size, true)
        {
            //a wide wheel
        }
    }
}
