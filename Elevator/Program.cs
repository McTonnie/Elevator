using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Elevator
{
    class Program
    {

        public static void call()
        {

        }

        static void Main(string[] args)
        {
            while (Variabler.power == true) // denne vil altid være true da den bare simulere der er strøm i elevatoren
            {
                if (Variabler.inside == false)
                {
                    do
                    {
                        output.etager();
                        Console.WriteLine("hvilken etage er du på lige nu");
                        Variabler.distination = (int)Taltjek.integertjek();
                        output.callscreen();
                        
                    }while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    etageskift.skift();
                    Variabler.inside = true;

                }
                
                while (Variabler.inside == true)
                {

                    Console.WriteLine("Hvor vil du gerne hen du er lige nu på etage " + Variabler.etage);
                    do
                    {
                        Variabler.distination = (int)Taltjek.integertjek();
                    } while (Variabler.distination == Variabler.etage);
                    etageskift.skift();
                    output.etager();
                    Console.WriteLine("vil du gå ud af elevatoren");
                    Console.WriteLine("1) ja");
                    Console.WriteLine("2) nej");
                    Variabler.valg = (int)Taltjek.integertjek();
                    if (Variabler.valg == 1)
                    {
                        Variabler.inside = false;
                    }


                }
            }
        }
    }
}
