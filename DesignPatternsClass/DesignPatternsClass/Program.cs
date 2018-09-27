using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using AbstractFactory;
using Builder;
using System.Collections;
using Iterator;
using Observer;
using Visitor;

namespace DesignPatternsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonPatternDemo();
            //AbstractFactoryPatternDemo();
            //BuilderPatternDemo();
            //IteratorPatternDemo();
            //IteratorPatternDemo2();
            //ObserverPatternDemo();
            VisitorPatternDemo();
        }

        private static void VisitorPatternDemo()
        {
            IWheel wheel = new WideWheel(24);
            wheel.AcceptVisitor(new WheelDiagnostics());
            wheel.AcceptVisitor(new WheelInventory());
        }

        private static void ObserverPatternDemo()
        {
            Speedometer mySpeedometer = new Speedometer();

            //two observers watching the above Speedometer
            SpeedMonitor monitor = new SpeedMonitor(mySpeedometer);
            GearBox auto = new GearBox(mySpeedometer);

            mySpeedometer.CurrentSpeed = 10;
            mySpeedometer.CurrentSpeed = 20;
            mySpeedometer.CurrentSpeed = 25;
            mySpeedometer.CurrentSpeed = 30;
            mySpeedometer.CurrentSpeed = 40;
        }

        private static void IteratorPatternDemo2()
        {
            Console.WriteLine("==== Road Bikes ====");
            RoadBikeRange roadRange = new RoadBikeRange();
            foreach (IBicycle bicycle in roadRange.Range)
            {
                Console.WriteLine(bicycle);
            }

            Console.WriteLine("==== Mountain Bikes ====");
            MountainBikeRange mountainRange = new MountainBikeRange();
            foreach (IBicycle bicycle in mountainRange.Range)
            {
                Console.WriteLine(bicycle);
            }
        }

        private static void IteratorPatternDemo()
        {
            Console.WriteLine("==== Road Bikes ====");
            RoadBikeRange roadRange = new RoadBikeRange();
            PrintIterator(roadRange.GetEnumerator());

            Console.WriteLine("==== Mountain Bikes ====");
            MountainBikeRange mountainRange = new MountainBikeRange();
            PrintIterator(mountainRange.GetEnumerator());
        }

        private static void PrintIterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
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
