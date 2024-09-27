namespace TicketClassLibrary;

public abstract class Vehicle
{
    private string _licensePlate;

    public string LicensePlate
    {
        get => _licensePlate;
        set
        {
            if (value.Length > 7)
            {
                throw new ArgumentException("License plate must be 7 or less than characters.");
            }
            
            _licensePlate = value;
        }
    }
    public DateTime Date { get; set; }

    /// <summary>
    /// Get the price of a ticket for a Vehicle
    /// </summary>
    /// <returns>Returns the price of the ticket as type double</returns>
    public double Price(bool brobizz)
    {
        double brobizzDiscount = 0.05; // 5% discount with brobizz
        
        if (brobizz)
        {
            return 125.0 * (1 - brobizzDiscount); // Calculate price with discount.
        }
        
        return 125.0;
    }

    /// <summary>
    /// Get the type of vehicle
    /// </summary>
    /// <returns>Returns the vehicle type as type string</returns>
    public abstract string VehicleType();
}