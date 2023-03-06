using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n, roznica;
            Console.WriteLine("Podaj wartosc m");
            m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Podaj wartosc n");
            n = Convert.ToInt16(Console.ReadLine());

            if (m > n)
            {
                do
                {
                    roznica = m - n;
                    m = roznica;
                } 
                while (roznica != 0);
            }
            else
            {
                do
                {
                    roznica = n - m;
                    n = roznica;
                }
                while (roznica != 0);
            }
        
        }
    }
}


 
    

