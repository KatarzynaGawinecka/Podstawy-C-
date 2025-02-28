using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód. 
            double a, b;
            Console.Write("Podaj bok a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj bok b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole to a*b={0}", a * b);
            Console.WriteLine("Obwód to 2*a+2*b={0}", 2 * a + 2 * b);
            Console.ReadKey(true); //pauza
   
        }
    }
}
