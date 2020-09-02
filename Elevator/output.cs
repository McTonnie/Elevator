using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class output
    {


        public static void etager()
        {
            Console.Clear();
            Console.WriteLine("-----------");
            Console.WriteLine("   _" + Variabler.retning + "_");
            Console.WriteLine("  |_" + Variabler.etage +"_|");
            Console.WriteLine("         ");
            Console.WriteLine("-----------");
        }
        public static void callscreen()
        {
            Console.WriteLine("------------");
            Console.WriteLine("|          |");
            Console.WriteLine("|  (call)  |");
            Console.WriteLine("|          |");
            Console.WriteLine("------------");
            Console.WriteLine("tryk på enter for at kalde på elevatoren og gå iind i den"); ;
        }

    }
}