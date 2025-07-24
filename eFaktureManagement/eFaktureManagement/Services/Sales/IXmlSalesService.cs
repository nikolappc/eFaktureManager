using eFaktureModel.Api.Models;
using eFaktureModel.Xml;
using XmlInvoice = eFaktureModel.Xml.Invoice;

namespace eFaktureManagement.Services.Sales
{
    public interface IXmlSalesService
    {
        Task<MiniInvoiceDto?> UploadUbl(string requestId, bool sendToCir, bool executeValidation, XmlInvoice xmlInvoice);
        Task<MiniInvoiceDto?> ImportUbl(string requestId, bool sendToCir, bool executeValidation, XmlInvoice xmlInvoice);
    }
}
