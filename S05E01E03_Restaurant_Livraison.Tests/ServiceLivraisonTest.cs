using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Livraison.Tests;

public class ServiceLivraisonTest
{
    [Fact]
    public void Constructor_CalculateurNull_LanceErreur()
    {
        Assert.Throws<ArgumentNullException>(() =>
            new ServiceLivraisons(null)
        );
    }

    [Fact]
    public void CalculerFrais_DélégationCalculFraisAStrategie_MemeResultatQueLaStrategie()
    {
        CalculateurFraisLivraisonPrioritaire calculateurFrais = new();
        ServiceLivraisons service = new(calculateurFrais);

        decimal expected = calculateurFrais.Calculer(10m, 4);
        decimal result = service.CalculerFrais(10m, 4);

        Assert.Equal(expected, result);
    }
}
