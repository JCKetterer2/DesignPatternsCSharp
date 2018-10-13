using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public interface IBicycle
    {
        IWheel Wheel { get; }
        BikeColor ColorType { get; }
        decimal Price { get; }

        void Paint(BikeColor color);

        void CleanFrame();
        void AirTires();
        void TestRide();
    }
}
