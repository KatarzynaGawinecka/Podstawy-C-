using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2__metody_
{
    class Program
    {
            // Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych 
            // zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.
            static double max(double x, double y)
            {
                if (x > y) return x;
                else return y;
            }
            static void main(string[] args)
            {
                Console.WriteLine("Max z 4 i 7 jest {0}", max(4, 7));
                Console.WriteLine("Max z 7 i 4 jest {0}", max(7, 4));
                Console.WriteLine("Max z 4 i 4 jest {0}", max(4, 4));
                Console.ReadKey(true);
            }

        }
    }

