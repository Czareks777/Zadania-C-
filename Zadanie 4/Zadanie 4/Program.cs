using System;
namespace Zadanie_4 
{
    class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Podaj wartość a: ");
            double a,b, temporary;
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartość b: ");
            b = Convert.ToDouble(Console.ReadLine());

            // temporary = a;
            // a = b;
            // b= temporary;
            (a, b) = (b, a);
            //Szybszy sposób
            Console.WriteLine("a={0}, b={1}",a, b);
        }
}
}
