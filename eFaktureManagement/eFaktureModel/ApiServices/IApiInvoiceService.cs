namespace eFaktureModel.ApiServices
{
    public interface IApiInvoiceService<C, I>
    {



        Task<List<C>?> GetChangesAsync(DateTime date);
        Task<List<long>?> GetIdsAsync(string status, DateTime from, DateTime to);
        Task<byte[]> GetPdfAsync(long invoiceId);
        Task<byte[]> GetXmlAsync(long invoiceId);
        Task<I?> GetInvoiceAsync(long invoiceId);

        Task<byte[]> DownloadSigned(long invoideId);

    }
}
