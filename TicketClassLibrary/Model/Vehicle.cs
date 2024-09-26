namespace TicketClassLibrary;

public abstract class Vehicle
{
    public string Licenseplate { get; set; }
    public DateTime Date { get; set; }

    /// <summary>
    /// Get the price of a ticket for a Vehicle
    /// </summary>
    /// <returns>Returns the price of the ticket as type double</returns>
    public double Price()
    {
        return 125.0;
    }

    /// <summary>
    /// Get the type of vehicle
    /// </summary>
    /// <returns>Returns the vehicle type as type string</returns>
    public abstract string VehicleType();
}