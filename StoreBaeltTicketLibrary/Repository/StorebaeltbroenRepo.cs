using TicketClassLibrary;

namespace StoreBaeltTicketLibrary.Repository;

public class StorebaeltbroenRepo<T> : IStorebaeltbroenRepo<T> where T : Vehicle
{
    public static List<T> _ticketRepository;

    public StorebaeltbroenRepo()
    {
        _ticketRepository = new List<T>();
    }

    public void addTicket(T vehicle)
    {
        if (vehicle != null)
        {
            _ticketRepository.Add(vehicle);
        }

        throw new NullReferenceException("vehicle is null");
    }
    
    public List<T> GetAllTickets() => _ticketRepository;
    public List<T> GetAllTicketForSpecificLicensePlate(string licensePlate) => _ticketRepository.FindAll(ticket => ticket.LicensePlate == licensePlate);
}