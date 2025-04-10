using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1__metody_
{
    class Program
    {
        // Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami 
        // całkowitymi.Napisz program wykorzystujący funkcję suma.
        static int suma(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("2+5={0}", suma(2, 5));
            Console.ReadKey(true);
        }

    }
}
