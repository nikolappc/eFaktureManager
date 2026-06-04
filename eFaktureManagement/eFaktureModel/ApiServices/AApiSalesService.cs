using eFaktureModel.Api.Config;
using eFaktureModel.Api.Models.Invoices;
using eFaktureModel.Api.Models.Sales;
using eFaktureModel.Api.Models.Vat;
using eFaktureModel.Enums;
using Microsoft.Extensions.Configuration;

namespace eFaktureManagement.ApiServices
{
    public abstract class AApiSalesService : ApiGenericInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>
    {
        protected AApiSalesService(IConfiguration configRoot, EFaktureApiRoot pathsConfirguration) : base(configRoot, pathsConfirguration)
        {
        }

        public abstract Task<MiniInvoiceDto?> UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml);
        public abstract Task<MiniInvoiceDto?> ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml);


        public abstract Task<InvoiceDto?> CancelDraft(long invoideId, string cancelComment);
        public abstract Task<InvoiceDto?> Storno(long invoideId, string stornoNumber, string stornoComment);
        public abstract Task<long?> DeleteDraft(long invoideId);
        public abstract Task<List<long>?> DeleteDrafts(List<long> invoiceIds);
        public abstract Task<ValueAddedTaxExemptionReasonDto?> GetValueAddedTaxExemptionReasonList();

    }
}
