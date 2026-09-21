using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Livraison.Tests;

public sealed class ClientTest
{
    [Theory]
    [InlineData("Or", 2000, true)]
    [InlineData("Or", 999, false)]
    [InlineData("", 2000, false)]
    public void EstPrioritaire_Theory_ReturnCorrectResponse(string status, int points, bool expectedResult)
    {
        Client client = new(status, points);

        bool result = client.EstPrioritaire();

        Assert.Equal(expectedResult, result);
    }
}
