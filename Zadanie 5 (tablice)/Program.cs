using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5__tablice_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym. 
            int[] tab = new int[1000];
            int i = 0, j, liczba;
            Console.Write("Podaj liczbę naturalną= ");
            liczba = Convert.ToInt32(Console.ReadLine());
            //TABLICA Z RESZTAMI
            while ((liczba / 2 != 0) || ((liczba / 2 == 0) && (liczba % 2 != 0)))
            {
                tab[i++] = liczba % 2;
                liczba /= 2;

            }
            // wypisanie elementów w odwrotnej kolejności
            for (j = i - 1; j >= 0; j--) Console.Write(tab[j]);
            Console.ReadKey(true);
        }
    }
}
