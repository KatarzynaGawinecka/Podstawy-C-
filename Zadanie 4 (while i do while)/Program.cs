using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4__while_i_do_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt 
            // posiadający n wierszy i k kolumn. Użyj pętli while.
            int n, k, i, j;
            Console.Write("Podaj liczbę (naturalną dodatnią) wierszy prostokata, n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę (naturalną dodatnią) kolumn prostokata, k=");
            k = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i<=n)
            {
                j = 1;
                while (j<=k)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine(" ");
                i++;
            }
            Console.ReadKey(true);

        }
    }
}
