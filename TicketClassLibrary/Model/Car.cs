namespace TicketClassLibrary;

/// <summary>
/// Class for car, which inherits from Vehicle
/// </summary>
public class Car : Vehicle
{
    /// <summary>
    /// Get the price of a ticket for a Car
    /// </summary>
    /// <returns>Returns the price of the ticket as type double</returns>
    public override double Price()
    {
        var brobizzDiscount = 0.05; 
        
        if (BroBizz)
        {
            return 240 * (1 - brobizzDiscount);
        }

        return 240;
    }
    
    /// <summary>
    /// method for getting vehicle type
    /// </summary>
    /// <returns>Returns the vehicle type as type string</returns>
    public override string VehicleType()
    {
        return "Car";
    }
}