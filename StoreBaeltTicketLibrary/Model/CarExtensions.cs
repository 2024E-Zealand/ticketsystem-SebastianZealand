using TicketClassLibrary;

namespace StoreBaeltTicketLibrary.Model;

public static class CarExtensions
{
    public static double GetStorebaeltPrice(this Car car)
    {
        double weekendDiscount = 0.2; // 20% discounto
        double brobizzDiscount = 0.05; // 5% discount
        double ticketPrice = 240.0; // Normal ticket price

        if (car.Date.DayOfWeek == DayOfWeek.Saturday || car.Date.DayOfWeek == DayOfWeek.Sunday)
        {
            ticketPrice *= (1 - weekendDiscount);
        }

        if (car.BroBizz)
        {
            ticketPrice *= (1 - brobizzDiscount);
        }
        
        return ticketPrice;
    }

}