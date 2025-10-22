using eFaktureManagement.Dto.Repository.Booking;
using eFaktureManagement.Filters;
using eFaktureManagement.Services.Paging;

namespace eFaktureManagement.Services.Purchase
{
    public interface IBookingService:IPagingService<BookingFilter, BookingPageItem>
    {
    }
}
