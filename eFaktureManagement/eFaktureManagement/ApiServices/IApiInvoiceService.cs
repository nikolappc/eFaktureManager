namespace eFaktureManagement.ApiServices
{
    public interface IApiInvoiceService<C, I>
    {

        List<C> GetChanges(DateTime date);
        List<long> GetIds(string status, DateTime from, DateTime to);
        byte[] GetXml(string invoiceId);
        I GetInvoice(string invoiceId);
    }
}
