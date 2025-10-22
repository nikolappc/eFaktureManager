using eFaktureManagement.Data;
using eFaktureManagement.Dto.Purchase.Booking;
using eFaktureManagement.Dto.Unassigned;
using eFaktureManagement.Filters;
using eFaktureManagement.Paging;
using eFaktureManagement.Services.Paging;

namespace eFaktureManagement.Services.Unassigned
{
    public class BookingPagingService : AbstractBasePagingService<BookingFilter, BookingPageItem>
    {
        eFaktureContext _context;

        public BookingPagingService(eFaktureContext context)
        {
            _context = context;
        }

        public override IQueryable<BookingPageItem> Query(int pageNumber, int pageSize, BookingFilter? filter = null, Sorting? s = null)
        {
            var items = (
                from inv in _context.PurchaseInvoices

                join ua in _context.UserInvoices on inv.InvoiceId equals ua.InvoiceId into uAJ
                from ua in uAJ.DefaultIfEmpty()
                join u in _context.Users on ua.UserId equals u.Id into uJ
                from u in uJ.DefaultIfEmpty()

                where (filter == null || (inv.LastModifiedUtc >= filter.StartDate && inv.LastModifiedUtc <= filter.EndDate && u.UserName == filter.UserName))
                where ua == null

                select new BookingPageItem
                {
                    InvoiceId = inv.InvoiceId,
                    LastModifiedUtc = inv.LastModifiedUtc,
                    Status = inv.Status,
                }
                );

            return items;
        }

        public async override Task<IQueryable<BookingPageItem>> QueryAsync(int pageNumber, int pageSize, BookingFilter? f = null, Sorting? s = null)
        {
            return Query(pageNumber, pageSize, f, s);    
        }
    }
}
