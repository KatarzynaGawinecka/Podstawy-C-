using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na ekranie objętość i pole całkowite tego stożka.
            Double r, h, l, V, Pc;
            Console.Write("Podaj promień podstawy stożka r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokość stożka h=");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Objętość stożka to");
            l = Math.Sqrt(r * r + h * h);
            V = 1.0 / 3 * Math.PI * r * r * h;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("Objętość stożka wynosi V={0}", V);
            Console.WriteLine("Pole całkowite stożka wynosi Pc={0}", Pc);
            Console.ReadKey(true); //pauza

        }
    }
}
