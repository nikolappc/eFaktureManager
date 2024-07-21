using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;

namespace eFaktureManagement.ApiServices
{
    public class ApiPurchaseInvoiceService : IApiInvoiceService<PurchaseInvoiceChange, PurchaseInvoiceDto>, IApiPurchaseService
    {
        public PurchaseAcceptRejectResponse AcceptPurhcaseInvoice(string invoiceId, string comment)
        {
            throw new NotImplementedException();
        }

        public List<PurchaseInvoiceChange> GetChanges(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<long> GetIds(string status, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public PurchaseInvoiceDto GetInvoice(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public bool GetSignature(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public byte[] GetXml(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public bool VatReverseCarge(string invoiceId, double ammount)
        {
            throw new NotImplementedException();
        }
    }
}
