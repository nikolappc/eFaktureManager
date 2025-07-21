using eFaktureManagement.Dto.Unassigned;
using eFaktureManagement.Models.Repository;

namespace eFaktureManagement.Repository
{
    public interface IUnassignedRepository
    {
        IQueryable<UnassignedItem> GetUnassignedInvoices(UnassignedFilter filter); 
        UnassignedItem? GetSingleUnassigned(int id);
        UnassignedItem? UpdateUnassigned(UnassignedItem? item);

    }
}
