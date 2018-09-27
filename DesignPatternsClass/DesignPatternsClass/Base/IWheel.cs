using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace DesignPatternsClass
{
    public interface IWheel : IVisitable
    {
        int Size { get; }
        bool Wide { get; }
    }
}
