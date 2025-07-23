using eFaktureManagement.ApiModels;

namespace eFaktureManagement.ApiServices
{
    public interface IApiSalesService
    {
        Task<MiniInvoiceDto?> UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml);
        Task<MiniInvoiceDto?> ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml);



    }
}
