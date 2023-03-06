class Program
{
    // zadanie 1 i 2
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę");
        double liczba1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj pierwszą liczbę");
        double liczba2 = double.Parse(Console.ReadLine());

        WyliczSredniaProceduralnie(liczba1,liczba2);
        double wynik = WyliczSredniaProceduralnie(liczba1, liczba2);
        Console.WriteLine("Średnia to: {0}", wynik);
        
        
        
        int silnie=1;
        Console.WriteLine("Podaj liczbę do silni: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i<=n; i++)
        {
            silnie *=i;
        }
        Console.WriteLine("Silnia wynosi {0}", silnie);
        
    }
    static Double WyliczSredniaProceduralnie(double liczba1, double liczba2)
    {
        double srednia = (liczba1 + liczba2 / 2);
    //Console.WriteLine("Średnia to: {0}", srednia);
        return srednia;
    }

}
