using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureModel.Api.Models;

namespace eFaktureManagement.ApiServices
{
    public class ApiPurchaseInvoiceService : IApiInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto>, IApiPurchaseService
    {
        public PurchaseAcceptRejectResponse AcceptPurhcaseInvoice(string invoiceId, string comment)
        {
            throw new NotImplementedException();
        }

        public List<PurchaseInvoiceStatusChangeDto> GetChanges(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<List<PurchaseInvoiceStatusChangeDto>> GetChangesAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<long> GetIds(string status, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<List<long>> GetIdsAsync(string status, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public SimplePurchaseInvoiceDto GetInvoice(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<SimplePurchaseInvoiceDto> GetInvoiceAsync(string invoiceId)
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

        public Task<byte[]> GetXmlAsync(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public bool VatReverseCarge(string invoiceId, double ammount)
        {
            throw new NotImplementedException();
        }
    }
}
