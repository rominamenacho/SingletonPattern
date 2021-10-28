using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConectionSingleton c = new ConectionSingleton(); no es posible gracias al constructor privado

            ConectionSingleton c = ConectionSingleton.getInstance(); //lo permite porque es static
            c.MethodOne();
            //ConectionSingleton c2 = ConectionSingleton.getInstance();

            Console.WriteLine("c Is unique instance? " + (c is ConectionSingleton) );
            //Console.WriteLine("c2 Is unique instance? " + (c2 is ConectionSingleton));

            Console.ReadKey();
        }
    }
}
