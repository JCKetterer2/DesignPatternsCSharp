using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using AbstractFactory;
using Builder;

namespace DesignPatternsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonPatternDemo();
            //AbstractFactoryPatternDemo();
            BuilderPatternDemo();
        }

        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
        }

        private static void AbstractFactoryPatternDemo()
        {
            string whatToMake = "road bike";
            AbstractBikeFactory factory = null;

            if(whatToMake.Equals("road bike"))
            {
                factory = new RoadBikeFactory();
            }
            else
            {
                factory = new MountainBikeFactory();
            }

            //Create the bike parts
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            //Show what we created
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(new WideWheel(24), BikeColor.Green);
            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);

            Console.WriteLine(bicycle);
        }
    }
}
