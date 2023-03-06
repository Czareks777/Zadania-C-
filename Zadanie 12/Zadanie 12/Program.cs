using System;

class Program
{
    static void Main()
    {
        const int start = 1;
        const int end = 10;
        int n = new Random().Next(start, end + 1);
        int m;

        do
        {
            Console.Write($"Podaj liczbę z przedziału od {start} do {end}: ");
            m = int.Parse(Console.ReadLine());
            if (m < n)
            {
                Console.WriteLine("Podana liczba jest za mała");
            }
            else if (m > n)
            {
                Console.WriteLine("Podana liczba jest za duża");
            }
            else
            {
                Console.WriteLine("Gratulacje zgadłeś!");
            }
        } while (m != n);

        Console.ReadKey();
    }
}
