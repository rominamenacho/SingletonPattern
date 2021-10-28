using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class ConectionSingleton
    {
        private static ConectionSingleton UniqueInstance = null;

        private ConectionSingleton() { }

        public static ConectionSingleton getInstance() {
            if (UniqueInstance == null) {

                UniqueInstance = new ConectionSingleton();
            }
            return UniqueInstance;
        }

        public void MethodOne()
        {
            Console.WriteLine( "im the method one");
        }

    }
}
