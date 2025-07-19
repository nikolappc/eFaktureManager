using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureManagement.ApiModels.Sale;
using eFaktureModel.Api.Models;
using eFaktureModel.ApiModels.Sale;
using eFaktureSync.ApiServices;
using Microsoft.Extensions.Configuration;
using System.Net.Mime;
using System.Text.Json;
using System.Web;

namespace eFaktureManagement.ApiServices
{
    public class ApiSaleInvoiceService : ApiGenericInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>, IApiSalesService
    {
       
        public ApiSaleInvoiceService(IConfiguration configRoot) : base(configRoot, ApiConstants.SALES_SINGLE, ApiConstants.SALES_CHANGES)
        {
        }

        public ApiModels.MiniInvoiceDto ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml)
        {
            throw new NotImplementedException();
        }

        public ApiModels.MiniInvoiceDto UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml)
        {
            throw new NotImplementedException();
        }
    }
}
