namespace Restaurant.Livraison;

public class ServiceLivraisons
{
    private ICalculateurFraisLivraison calculateurFraisLivraison;

    public ServiceLivraisons(ICalculateurFraisLivraison calculateurFraisLivraison)
    {
        ArgumentNullException.ThrowIfNull(calculateurFraisLivraison, nameof(calculateurFraisLivraison));
        this.calculateurFraisLivraison = calculateurFraisLivraison;
    }

    public decimal CalculerFrais(decimal sousTotal, double distanceKm)
    {
        return this.calculateurFraisLivraison.Calculer(sousTotal,  distanceKm); 
    }
}
