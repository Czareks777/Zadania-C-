using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, v;
            Console.WriteLine("podaj x ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj y ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj z ");
            z = Convert.ToDouble(Console.ReadLine());

            v = ((4 * x-y) / (3 * (Math.Sqrt(z) + 1)));

            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
