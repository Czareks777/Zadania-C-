using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, v;
            Console.WriteLine("Podaj zmienna x: ");
            x=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Podaj zmienna y: ");
            y = Convert.ToInt16(Console.ReadLine());

            if (x < 0 & y < 0)
            {

                z = x * y;
                Console.WriteLine("z= {0} ", z);
            }
            else if (x == 0 || y == 0)
            {
                z = 10;
                Console.WriteLine("z= {0} ", z);
            }
            else
            {
                z = x + y;
                Console.WriteLine("z= {0} ",z);
            }

            Console.ReadLine();
        }
        }
    }

