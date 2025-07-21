using eFaktureManagement.Data;
using eFaktureManagement.Dto.Unassigned;
using eFaktureManagement.Models.Repository;

namespace eFaktureManagement.Repository
{
    public class UnassignedRepository : IUnassignedRepository
    {

        private readonly eFaktureContext _context;

        public UnassignedRepository(eFaktureContext context)
        {
            _context = context;
        }

        public UnassignedItem? GetSingleUnassigned(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UnassignedItem> GetUnassignedInvoices(UnassignedFilter filter)
        {
            var items = (
                from invoice in _context.PurchaseInvoices

                join ia in _context.UserInvoices on invoice.InvoiceId equals ia.InvoiceId into invoiceAssignments
                where !invoiceAssignments.Any()

                select new UnassignedItem
                {

                }

                );

            return items;
        }

        public UnassignedItem? UpdateUnassigned(UnassignedItem? item)
        {
            throw new NotImplementedException();
        }
    }
}
