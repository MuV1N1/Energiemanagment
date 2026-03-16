namespace EnergieManagment;

class Program
{
    static void Main(string[] args)
    {
        UmweltModul.Windgeschwindigkeit = 10.0;
        Straßenlaternen laterne1 = new Straßenlaternen("An");
        Straßenlaternen laterne2 = new Straßenlaternen("Aus");
        Straßenlaternen laterne3 = new Straßenlaternen("An");
        
        Console.WriteLine(laterne2.Status);
        Console.WriteLine(Straßenlaternen.GesamtzahlLaternen);
    }
}