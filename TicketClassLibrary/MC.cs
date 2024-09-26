namespace TicketClassLibrary;

public class MC
{
    public string Licenseplate { get; set; }
    public DateTime Date { get; set; }

    public double Price()
    {
        return 125.0;
    }

    public string Vehicle()
    {
        return "MC";
    }
}