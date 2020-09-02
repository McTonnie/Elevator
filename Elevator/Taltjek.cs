using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Taltjek
    {

        public static double doubletjek()
        {


            double res = 0;
            bool truetjek = false;
            while (truetjek == false)
            {
                truetjek = double.TryParse(Console.ReadLine(), out res);
                if (truetjek == false)
                    Console.WriteLine("Du kan kun skrive tal her prøv igen");

            }

            return res;
        }
        public static double integertjek()
        {


            int res = 0;
            bool truetjek = false;
            while (truetjek == false)
            {
                truetjek = Int32.TryParse(Console.ReadLine(), out res);
                if (truetjek == false)
                    Console.WriteLine("Du kan kun skrive heltal her prøv igen");

            }

            return res;
        }
    }
}
