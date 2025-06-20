namespace eFaktureManagement.ApiServices
{
    public interface IApiInvoiceService<C, I>
    {

        List<C> GetChanges(DateTime date);
        List<long> GetIds(string status, DateTime from, DateTime to);
        byte[] GetXml(string invoiceId);
        I GetInvoice(string invoiceId);



        Task<List<C>> GetChangesAsync(DateTime date);
        Task<List<long>> GetIdsAsync(string status, DateTime from, DateTime to);
        Task<byte[]> GetXmlAsync(string invoiceId);
        Task<I> GetInvoiceAsync(string invoiceId);
    }
}
