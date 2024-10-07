using TicketClassLibrary;

namespace OresundbronTicketLibrary.Model;

public static class CarExtensions
{
    public static double GetOresundbronPrice(this Car car)
    {
        var ticketPrice = 410;

        if (car.BroBizz)
        {
            return 161;
        }

        return ticketPrice;
    }

    public static string GetOresundbronVehicleType(this Car car)
    {
        return "Oresund car";
    }
}