using eFaktureManagement.ApiModels;

namespace eFaktureManagement.ApiServices
{
    public interface IApiSalesService
    {
        MiniInvoiceDto UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml);
        MiniInvoiceDto ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml);



    }
}
