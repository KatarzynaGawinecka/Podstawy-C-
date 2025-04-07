using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6__tablice_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli foreach.
            String[] dni = new string[] { "poniedziałek", "wtorek", "środa", "czwartek", "piątek" };
            foreach (string elem in dni)
                Console.Write("{0}, ", elem);
            Console.ReadKey(true);
            
        }
    }
}
