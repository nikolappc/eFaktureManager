using eFaktureManagement.Paging;

namespace eFaktureManagement.Services.Paging
{
    public interface IPagingService<F, T>
    {


      

        Page<T> GetPage(int pageNumber, int pageSize, F? filter=default, Sorting? s = null  );

        Task<Page<T>> GetPageAsync(int pageNumber, int pageSize, F? filter =default, Sorting? s = null  );

    }
}
