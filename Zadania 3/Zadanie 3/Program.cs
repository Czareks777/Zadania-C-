using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe do sprawdzenia czy jest parzysta");
            double number = double.Parse(Console.ReadLine());
            
            if (number%2!=1)
            {
                Console.WriteLine("Liczba" +number+" jest parzysta");
            }
            else Console.WriteLine("Liczba "+number+" nie jest parzysta");
            Console.ReadLine();
        }
            
    }
}
