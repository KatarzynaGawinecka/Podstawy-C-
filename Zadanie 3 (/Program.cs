using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__
{
    class Program
    {

            // Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca 
            // obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.
            static double pole_kola(double r)
            {
                return Math.PI * r * r;
            }
             static void main(string[] args)
           {
            Console.WriteLine("Pole koła o promineiu r=2 wynsoi {0}", pole_kola(2));
            Console.ReadKey(true);
             }
        }
    
}