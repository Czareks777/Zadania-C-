using System;

namespace Podatek
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal VAT= 0.22m;
            Console.WriteLine("Podaj wartość netto ");
            decimal netto=Convert.ToDecimal(Console.ReadLine());
            decimal brutto = (netto * VAT) + netto;
            decimal podatek = netto * VAT;
            Console.WriteLine("Podatek wynosi {0}",podatek);
            Console.WriteLine("Kwota brutto wynosi {0}",brutto);
            
            Console.ReadLine();
        }
    }
}
