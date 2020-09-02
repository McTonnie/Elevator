using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Elevator
{
    class etageskift
    {
        public static void skift()
        {
            while (Variabler.distination > Variabler.etage)
            {
                Thread.Sleep(2000);
                Variabler.etage++;
                Variabler.retning = Variabler.op;
                output.etager();

            }
            while (Variabler.distination < Variabler.etage)
            {
                Thread.Sleep(2000);
                Variabler.etage--;
                Variabler.retning = Variabler.ned;
                output.etager();
 

            }
        }

    }
}
