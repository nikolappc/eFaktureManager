namespace eFaktureManagement.ApiServices
{
    public interface IApiInvoiceService<C, I>
    {



        Task<List<C>?> GetChangesAsync(DateTime date);
        Task<List<long>?> GetIdsAsync(string status, DateTime from, DateTime to);
        Task<byte[]> GetXmlAsync(long invoiceId);
        Task<I?> GetInvoiceAsync(long invoiceId);
    }
}
