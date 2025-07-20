using eFaktureManagement.Paging;

namespace eFaktureManagement.Services.Paging
{
    public interface IPagingService<F, T>
    {


        Page<T> GetPage(int pageNumber, int pageSize);

        Task<Page<T>> GetPageAsync(int pageNumber, int pageSize);
        Page<T> GetPage(int pageNumber, int pageSize, Sorting? s);

        Task<Page<T>> GetPageAsync(int pageNumber, int pageSize, Sorting? s);

        Page<T> GetPage(int pageNumber, int pageSize, F? filter, Sorting? s);

        Task<Page<T>> GetPageAsync(int pageNumber, int pageSize, F? filter, Sorting? s);

    }
}
