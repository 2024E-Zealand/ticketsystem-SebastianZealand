namespace TicketClassLibrary;

public class Car
{
    public string Licenseplate { get; set; }
    public DateTime Date { get; set; }

    public double Price()
    {
        return 125.0;
    }

    public string Vechile()
    {
        return "MC";
    }
}