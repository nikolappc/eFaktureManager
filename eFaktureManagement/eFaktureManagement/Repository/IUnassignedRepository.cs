using eFaktureManagement.Dto.Repository;
using eFaktureManagement.Dto.Repository.Booking;
using eFaktureManagement.Dto.Unassigned;

namespace eFaktureManagement.Repository
{
    public interface IUnassignedRepository
    {
        IQueryable<UnassignedItem> GetUnassignedInvoices(UnassignedFilter filter); 
        UnassignedItem? GetSingleUnassigned(int id);
        UnassignedItem? UpdateUnassigned(UnassignedItem? item);

    }
}
