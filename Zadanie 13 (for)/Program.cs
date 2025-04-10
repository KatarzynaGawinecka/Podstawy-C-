using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_13__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj liczbę naturalną n (n>4). Narysuj na ekranie ze znaków X kontur trójkąta prostokątnego jak na poniższym przykładzie.
            // Użyj pętli for. 
            int n, i, j;
            Console.Write("Podaj liczbę naturalną większą od 4, n>4 :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) //wiersze
            {
                for (j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == n)
                        Console.Write("X");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
                Console.ReadKey(true);
              
        }
    }
}
