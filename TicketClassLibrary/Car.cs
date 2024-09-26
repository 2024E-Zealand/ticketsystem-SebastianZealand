namespace TicketClassLibrary;

/// <summary>
/// 
/// </summary>
public class Car
{
    public string Licenseplate { get; set; }
    public DateTime Date { get; set; }
    
    /// <summary>
    /// Get the price of a car
    /// </summary>
    /// <returns>Returns the price of the car as type double</returns>
    public double Price()
    {
        return 125.0;
    }

    /// <summary>
    /// Get the type of vehicle
    /// </summary>
    /// <returns>Returns the vehicle type as type string</returns>
    public string Vehicle()
    {
        return "Car";
    }
}