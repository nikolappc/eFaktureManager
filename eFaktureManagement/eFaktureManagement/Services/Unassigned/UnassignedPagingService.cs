using eFaktureManagement.Data;
using eFaktureManagement.Dto.Unassigned;
using eFaktureManagement.Paging;
using eFaktureManagement.Services.Paging;

namespace eFaktureManagement.Services.Unassigned
{
    public class UnassignedPagingService : AbstractBasePagingService<UnassignedFilter, UnassignedPageItem>
    {
        eFaktureContext _context;

        public UnassignedPagingService(eFaktureContext context)
        {
            _context = context;
        }

        public override IQueryable<UnassignedPageItem> Query(int pageNumber, int pageSize, UnassignedFilter? filter = null, Sorting? s = null)
        {
            throw new NotImplementedException();
        }

        public override Task<IQueryable<UnassignedPageItem>> QueryAsync(int pageNumber, int pageSize, UnassignedFilter? f = null, Sorting? s = null)
        {
            throw new NotImplementedException();
        }
    }
}
