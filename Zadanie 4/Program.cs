using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej i największej z tych liczb.
            double a, b, c, d, e, min, max;
            Console.Write("Podaj liczbę a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę d=");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę e=");
            e = Convert.ToDouble(Console.ReadLine());
            // minimum 
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Najmniejszą liczbą jest= {0}", min);
            // maximum
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Największą liczbą jest= {0}", max);
            Console.ReadKey(true);



           

        }
    }
}
