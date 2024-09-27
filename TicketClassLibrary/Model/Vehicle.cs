namespace TicketClassLibrary;

/// <summary>
/// Class vehicle used for creating basic functionality for managing vehicle crossing bridges.
/// </summary>
public abstract class Vehicle
{
    /// <summary>
    /// private variable licensePlate used for validation of property LicensePlate
    /// </summary>
    private string _licensePlate;

    /// <summary>
    /// Property for license plate, as type string
    /// </summary>
    /// <exception cref="ArgumentException">If license plate number is longer than 7 char.</exception>
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
    /// <summary>
    /// Property for date, as type DateTime
    /// </summary>
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