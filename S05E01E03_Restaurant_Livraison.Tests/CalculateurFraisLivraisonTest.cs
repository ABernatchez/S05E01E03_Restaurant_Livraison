using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Livraison.Tests;

public enum CalculateurFraisType
{
    Prioritaire,
    Standard,
    Gratuit
}

public class CalculateurFraisLivraisonTest
{
    public static CalculateurFraisLivraisonPrioritaire calculateurPrioritaire = new();
    public static CalculateurFraisLivraisonStandard calculateurStandard = new();
    public static CalculateurFraisLivraisonGratuit calculateurGratuit = new(calculateurStandard);


    [Fact]
    public void ConstructorGratuit_CalculateurStandardNull_LanceErreur()
    {
        Assert.Throws<ArgumentNullException>(() =>
            new CalculateurFraisLivraisonGratuit(null)
        );
    }


    [Theory]
    [InlineData(CalculateurFraisType.Prioritaire, 40, 2, 4)]
    [InlineData(CalculateurFraisType.Standard, 40, 4, 7)]
    [InlineData(CalculateurFraisType.Gratuit, 25, 4, 7)]
    [InlineData(CalculateurFraisType.Gratuit, 50, 40, 0)]
    public void Calculer_Theory_RetourneBonFrais(CalculateurFraisType calculateurType, decimal sousTotal, double dist, decimal expectedResult)
    {
        decimal frais = 0m;
        switch (calculateurType)
        {
            case CalculateurFraisType.Prioritaire:
                frais = calculateurPrioritaire.Calculer(sousTotal, dist);
                break;
            case CalculateurFraisType.Standard:
                frais = calculateurStandard.Calculer(sousTotal, dist);
                break;
            case CalculateurFraisType.Gratuit:
                frais = calculateurGratuit.Calculer(sousTotal, dist);
                break;
        }

        Assert.Equal(expectedResult, frais);
    }
}
