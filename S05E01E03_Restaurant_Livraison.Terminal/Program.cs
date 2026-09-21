using Restaurant.Livraison;

internal static class Program
{
    public static ICalculateurFraisLivraison ChoisirCalculateur(Client client, string mode)
    {
        if (mode == "gratuit")
        {
            return new CalculateurFraisLivraisonGratuit(new CalculateurFraisLivraisonStandard());
        }

        if (mode == "prioritaire" && client.EstPrioritaire())
        {
            return new CalculateurFraisLivraisonPrioritaire();
        }

        return new CalculateurFraisLivraisonStandard();
    }

    public static void Main(string[] args)
    {
        Client client = new("Or", 1200);
        ServiceLivraisons service = new(ChoisirCalculateur(client, "prioritaire"));

        decimal frais = service.CalculerFrais(35m, 4);

        Console.Out.WriteLine($"Frais : {frais:C}");
    }
}
