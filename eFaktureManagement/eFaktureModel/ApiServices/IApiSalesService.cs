

using eFaktureModel.Api.Models;

namespace eFaktureManagement.ApiServices
{
    public interface IApiSalesService
    {
        Task<MiniInvoiceDto?> UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml);
        Task<MiniInvoiceDto?> ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml);


        Task<InvoiceDto> CancelDraft(long invoideId, string cancelComment);
        Task<InvoiceDto> Storno(long invoideId, string stornoNumber, string stornoComment);
        Task DeleteDraft(long invoideId);

        // TODO GET /api/publicApi/sales-invoice/getValueAddedTaxExemptionReasonList


    }
}
