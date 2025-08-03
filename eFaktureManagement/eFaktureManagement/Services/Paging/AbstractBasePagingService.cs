using eFaktureManagement.Paging;

namespace eFaktureManagement.Services.Paging
{
    public abstract class AbstractBasePagingService<F, T>:IPagingService<F, T> 
    {
        public abstract IQueryable<T> Query(int pageNumber, int pageSize, F? filter = default, Sorting? s = null);  
        public abstract Task<IQueryable<T>> QueryAsync(int pageNumber, int pageSize, F? f = default, Sorting? s = null);




        private Page<T> PreparePage(IQueryable<T> query, int pageNumber, int pageSize, int totalCount)
        {

            var total = query.Count();

            query = query.Skip(pageSize * pageNumber).Take(pageSize);

            var list = query.ToList();

            return new Page<T>(list, total, pageNumber, pageSize);
        }   


        public Page<T> GetPage(int pageNumber, int pageSize, F? filter = default, Sorting? s = null)
        {
            var query = Query(pageNumber, pageSize, filter, s);

            return PreparePage(query, pageNumber, pageSize, query.Count()); 
       
        }   


        public async Task<Page<T>> GetPageAsync(int pageNumber, int pageSize, F? filter = default, Sorting? s = null)
        {
            var query = await QueryAsync(pageNumber, pageSize, filter, s);


            return PreparePage(query, pageNumber, pageSize, query.Count());

        }


    }
}
