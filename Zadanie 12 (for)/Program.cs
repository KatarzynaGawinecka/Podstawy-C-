using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for. (h=6 w przykładzie)
            int h, i, j;
            Console.Write("Podaj wysokość h=");
            h = Convert.ToInt32(Console.ReadLine());
            for (i=1; i<=h; i++) //wiersze
            {
                for (j = 1; j <= i; j++) Console.Write("{0} ", i*j);
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
