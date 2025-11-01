using eFaktureModel.Api.Models.Invoices;
using eFaktureModel.Api.Models.Vat;

namespace eFaktureManagement.ApiServices
{
    public interface IApiSalesService
    {
        Task<MiniInvoiceDto?> UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml);
        Task<MiniInvoiceDto?> ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml);


        Task<InvoiceDto?> CancelDraft(long invoideId, string cancelComment);
        Task<InvoiceDto?> Storno(long invoideId, string stornoNumber, string stornoComment);
        Task<long?> DeleteDraft(long invoideId);
        Task<List<long>?>DeleteDrafts(List<long> invoiceIds);
        Task<ValueAddedTaxExemptionReasonDto?> GetValueAddedTaxExemptionReasonList();

    }
}
