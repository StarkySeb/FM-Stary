namespace zvirata{
   internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

         VytvorZvire vytvorZvire = new VytvorZvire();

        List<Func<Zvire>> zvirata = new List<Func<Zvire>>()
        {
            vytvorZvire.VytvorKocku,
            vytvorZvire.VytvorPes,
            vytvorZvire.VytvorKun,
            vytvorZvire.VytvorKrava,
            vytvorZvire.VytvorOvce,
            vytvorZvire.VytvorKoza,
            vytvorZvire.VytvorPrase,
            vytvorZvire.VytvorKachna,
            vytvorZvire.VytvorSlepice,
            vytvorZvire.VytvorLama,

        };

                // Cyklus pro vytvoření všech zvířat a výpis jejich informací
        foreach (Func<Zvire> vytvoritZvire in zvirata){
            Zvire zvire = vytvoritZvire(); // Vytvoří zvíře
            zvire.VypisInfo(); // Vypíše informace o zvířeti
        }

    }
} 
}