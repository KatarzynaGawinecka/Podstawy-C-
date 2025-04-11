using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1__do_i_do_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z 
            //przedziału[a, b].Użyj pętli while.
            int a, b, i;
            Console.Write("Podaj liczbę naturalną a, która jest większa od 0. a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę naturalną b, która jest większa od 0 i a. b=");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while (i<=b)
            {
                if (i % 2 == 0) Console.Write("{0}, ", i);
                i++;
            }
            Console.ReadKey(true);


        }
    }
}
