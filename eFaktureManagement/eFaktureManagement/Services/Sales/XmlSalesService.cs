using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Models.Invoices;

namespace eFaktureManagement.Services.Sales
{
    public class XmlSalesService : IXmlSalesService
    {

        private readonly AApiSalesService apiSalesService;

        public XmlSalesService(AApiSalesService apiSalesService)
        {
            this.apiSalesService = apiSalesService;
        }

        public async Task<MiniInvoiceDto?> ImportUbl(string requestId, bool sendToCir, bool executeValidation, eFaktureModel.Xml.Invoice xmlInvoice)
        {
            var txt = CreateAndValidateXml(xmlInvoice); 

            return await apiSalesService.ImportUbl(requestId, sendToCir, executeValidation, txt); 
        }

        private string CreateAndValidateXml(eFaktureModel.Xml.Invoice xmlInvoice)
        {
            var txt = XmlUtil.SerializeInvoice(xmlInvoice);



            var xsdPath = XmlUtil.GetXsdPath();


            XmlUtil.ValidateXml(txt, xsdPath);

            return txt;
        }   

        public async Task<MiniInvoiceDto?> UploadUbl(string requestId, bool sendToCir, bool executeValidation, eFaktureModel.Xml.Invoice xmlInvoice)
        {
            var txt =CreateAndValidateXml(xmlInvoice); 

            var bytes = System.Text.Encoding.UTF8.GetBytes(txt);

            return await apiSalesService.UploadUbl(requestId, sendToCir, executeValidation, bytes);   

        }
    }
}
