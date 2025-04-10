using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata przestępne od 
            // od roku_początkowego do roku_końcowego włącznie. Użyj pętli for.
            int rok_1, rok_2, i;
            Console.Write("Podaj rok początkowy:");
            rok_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj rok końcowy:");
            rok_2= Convert.ToInt32(Console.ReadLine());
            for (i=rok_1; i<=rok_2; i++)
            {
                if ((i % 4 == 0) && (i % 100 != 0) || (i % 400 == 0)) Console.WriteLine("{0}, ", i);
            }
            Console.ReadKey(true);
        }
    }
}
