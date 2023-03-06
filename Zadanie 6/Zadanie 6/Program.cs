using System;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.WriteLine("Podaj promien kola" );
            r =Convert.ToDouble(Console.ReadLine());
            double pole=Math.PI*Math.Sqrt(r);
            double obwod = Math.PI * 2 * r;

            Console.WriteLine("Pole wynosi {0:F3} ",pole);
            Console.WriteLine("Obwod wynosi {0:F3} ",obwod);
            Console.ReadLine();
        }
    }
}
