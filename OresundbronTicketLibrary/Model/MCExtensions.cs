using TicketClassLibrary;

namespace OresundbronTicketLibrary.Model;

public static class MCExtensions
{
    public static double GetOresundbronPrice(this MC mc)
    {
        var ticketPrice = 210.0;

        if (mc.BroBizz)
        {
            return 73.0;
        }

        return ticketPrice;
    }

    public static string GetOresundbronVehicleType(this MC mc)
    {
        return "Oresund MC";
    }
}