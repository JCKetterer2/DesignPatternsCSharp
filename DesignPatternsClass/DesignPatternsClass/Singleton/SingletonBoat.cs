using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonBoat
    {
        private static volatile SingletonBoat instance;
        private string[] boatNames = { "Sandy", "Marina", "Minnow" };

        public static SingletonBoat Instance
        {
            get
            {
                if (instance == null)
                {
                        if (instance == null)
                        {
                            instance = new SingletonBoat();
                        }
                }
                return instance;
            }
        }

        private SingletonBoat() { }

        public virtual int BoatNames
        {
            get { return boatNames.Length; }
        }

    }
}
