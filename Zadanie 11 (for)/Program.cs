using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_11__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać 
            //od użytkownika. Przykładowo dla n = 3 należy obliczyć sumę 1 + 3 + 5. Do obliczenia wartości sumy użyj pętli for. 
            int n, i, suma=0;
            Console.Write("Podaj n początkowych liczb nieparzystych, których sumę mogę obliczyć. n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<n;i++)
            {
                suma += 2 * i + 1;
            }
            Console.WriteLine("Suma wynosi= {0}",suma);
            Console.ReadKey(true);

        }
    }
}
