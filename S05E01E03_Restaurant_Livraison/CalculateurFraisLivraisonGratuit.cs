namespace Restaurant.Livraison;

public class CalculateurFraisLivraisonGratuit : ICalculateurFraisLivraison
{
    private ICalculateurFraisLivraison calculateurFrais;

    public CalculateurFraisLivraisonGratuit(ICalculateurFraisLivraison calculateurFrais)
    {
        ArgumentNullException.ThrowIfNull(calculateurFrais, nameof(calculateurFrais));
        this.calculateurFrais = calculateurFrais;
    }

    public decimal Calculer(decimal sousTotal, double distanceKm)
    {
        return sousTotal >= 50m ? 0m : this.calculateurFrais.Calculer(sousTotal, distanceKm);
    }
}
