using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna czy też równa 0. 
            int a;
            Console.Write("Podaj liczbę a=");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba {0} jest dodatnia.", a);
            else if (a < 0)
                Console.WriteLine("Liczba {0} jest ujemna.", a);
            else
                Console.WriteLine("Liczba {0} jest równa 0.", a);
            Console.ReadKey(true); //pauza
                    
           

        }
    }
}
