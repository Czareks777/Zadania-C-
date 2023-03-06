using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8_9
{
    // to sa dwa zadania w jednym
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a, b,c,d, max;
            Console.WriteLine("Podaj wartosc a ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wartosc b ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wartosc c ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wartosc d ");
            d = Convert.ToInt32(Console.ReadLine());
            */
            int[] tablica = new int[4];
           for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Podaj liczbe do tablicy: ");
                tablica[i] = Convert.ToInt16(Console.ReadLine());
            }
           
            Console.WriteLine("Maksymalna wartosc w tablicy to {0} ",tablica.Max());

            // max= Math.Max(Math.Max(a,b), Math.Max(c,d));
           // Console.WriteLine("Wartosc max wynosi {0}",max);
            // W tym przypadku zadziala ale jest to podejscie jaskiniowca
            Console.ReadLine();
        }
    }
}
