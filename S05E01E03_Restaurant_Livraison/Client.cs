namespace Restaurant.Livraison;

public class Client
{
    private string status { get; }
    private int pointsFidelite { get; }

    public Client(string status, int pointsFidelite)
    {
        this.status = status;
        this.pointsFidelite = pointsFidelite;
    }

    public bool EstPrioritaire()
    {
        return this.status == "Or" && this.pointsFidelite >= 1000;
    }
}
