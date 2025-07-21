using eFaktureManagement.Dto.Unassigned;
using eFaktureManagement.Paging;
using eFaktureManagement.Services.Paging;

namespace eFaktureManagement.Services.Unassigned
{
    public class UnassignedPagingService : IPagingService<UnassignedFilter, UnassignedPageItem>
    {
        public Page<UnassignedPageItem> GetPage(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Page<UnassignedPageItem> GetPage(int pageNumber, int pageSize, Sorting? s)
        {
            throw new NotImplementedException();
        }

        public Page<UnassignedPageItem> GetPage(int pageNumber, int pageSize, UnassignedFilter? filter, Sorting? s)
        {
            throw new NotImplementedException();
        }

        public Task<Page<UnassignedPageItem>> GetPageAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Page<UnassignedPageItem>> GetPageAsync(int pageNumber, int pageSize, Sorting? s)
        {
            throw new NotImplementedException();
        }

        public Task<Page<UnassignedPageItem>> GetPageAsync(int pageNumber, int pageSize, UnassignedFilter? filter, Sorting? s)
        {
            throw new NotImplementedException();
        }
    }
}
