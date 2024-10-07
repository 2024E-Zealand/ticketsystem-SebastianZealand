using TicketClassLibrary;

namespace StoreBaeltTicketLibrary.Repository;

public interface IStorebaeltbroenRepo<T> where T : Vehicle
{
    void addTicket(T vehicle);
    List<T> GetAllTickets();
    List<T> GetAllTicketForSpecificLicensePlate(string licensePlate);
}