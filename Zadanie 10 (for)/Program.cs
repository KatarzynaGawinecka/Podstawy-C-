using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program drukujący na ekranie kolejne liczby naturalne podzielne przez 7. Ilość liczb 
            // wczytaj z klawiatury.Użyj pętli for. Oto wydruk dla ile = 6: 
            // 0, 7, 14, 21, 28, 35
            int n, i;
            Console.Write("Podaj ile liczb natrualnych podzielnych przez 7 mam wypisać, n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<n;i++)
            {
                Console.Write("{0}, ", i*7);
            }
            Console.ReadKey(true);

        }
    }
}
