namespace TicketClassLibrary;

/// <summary>
/// Class for motorcycles, which inherits from Vehicle
/// </summary>
public class MC : Vehicle
{
    /// <summary>
    /// Get the price of a ticket for a Motorcycle
    /// </summary>
    /// <returns>Returns the price of the ticket as type double</returns>
    public override double Price()
    {
        var brobizzDiscount = 0.05;

        if (BroBizz)
        {
            return 125 * (1 - brobizzDiscount);
        }

        return 125;
    }
    
    /// <summary>
    /// method for getting type of vehicle
    /// </summary>
    /// <returns>Returns the vehicle type as type string</returns>
    public override string VehicleType()
    {
        return "MC";
    }
}