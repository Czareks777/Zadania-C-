using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sprawdzLiczbePierwsza();
        }

        static void sprawdzLiczbePierwsza()
        {
            Console.WriteLine("Podaj liczbe: ");
            int liczba = Convert.ToInt16(Console.ReadLine());
            if (liczba == 2)
            {
                Console.WriteLine("liczba {0} jest liczba pierwsza", liczba);
            }
            else if (liczba % 2 != 0)
            {
                Console.WriteLine("Liczba {0} nie jest pierwsza", liczba);
            }
            else
            {
                bool lpierwsza = true;
                for (int i = 3; i == Math.Sqrt(liczba); i += 2)
                {
                    if (liczba % 2 == 0)
                    {
                        lpierwsza = false;
                        Console.WriteLine("Liczba {0} nie jest liczba pierwsza ", liczba);
                        break;
                    }
                }
                if (lpierwsza == true)
                {
                    Console.WriteLine("Liczba {0} jest liczbą pierwszą");
                }
            }
            Console.ReadLine();
        }
        

    }


}

