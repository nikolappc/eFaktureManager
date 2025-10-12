using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureManagement.ApiModels.Sale;
using eFaktureModel.Api.Models;
using eFaktureModel.ApiModels.Sale;
using eFaktureModel.ApiServices.Util;
using eFaktureModel.Enums;
using eFaktureSync.ApiServices;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MiniInvoiceDto = eFaktureModel.Api.Models.MiniInvoiceDto;

namespace eFaktureManagement.ApiServices
{
    public class ApiSaleInvoiceService : ApiGenericInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>, IApiSalesService
    {

        public ApiSaleInvoiceService(IConfiguration configRoot) : base(configRoot, SalesApiPaths.Paths)
        {
        }

        public Task<InvoiceDto> CancelDraft(long invoideId, string cancelComment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDraft(long invoideId)
        {
            throw new NotImplementedException();
        }

        public async Task<ValueAddedTaxExemptionReasonDto?> GetValueAddedTaxExemptionReasonList()
        {
            using (var httpClient = new HttpClientBuilder<ValueAddedTaxExemptionReasonDto?>(configRoot))
            {

                httpClient
                    .AddPath(PathsConfirguration[EApiPaths.VAT_EXEMPTIONS]);

                var response = await httpClient.GetResult();

                return response;
            }
        }

        public async Task<MiniInvoiceDto?> ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml)
        {
            using (var httpClient = new HttpClientBuilder<MiniInvoiceDto?>(configRoot))
            {
                var queryParams = new Dictionary<string, string?>
                {
                    { "requestId", requestId },
                    { "sendToCir", sendToCir.ToString() },
                    { "executeValidation", executeValidation.ToString() }
                };
                httpClient
                    .AddHttpContentText(xml, Encoding.UTF8)
                    .AddPath(PathsConfirguration[EApiPaths.UBL])
                    .AddQueryParams(queryParams);

                var response = await httpClient.PostResult();

                return response;
            }
        }

        public Task<InvoiceDto> Storno(long invoideId, string stornoNumber, string stornoComment)
        {
            throw new NotImplementedException();
        }

        public async Task<MiniInvoiceDto?> UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml)
        {
            using (var httpClient = new HttpClientBuilder<MiniInvoiceDto?>(configRoot))
            {

   var queryParams = new Dictionary<string, string?>
                {
                    { "requestId", requestId },
                    { "sendToCir", sendToCir.ToString() },
                    { "executeValidation", executeValidation.ToString() }
                };

                httpClient.AddHttpContentUbl(xml)
                    .AddPath(PathsConfirguration[EApiPaths.UBL_UPLOAD])
                    .AddQueryParams(queryParams);


             


                var response = await httpClient.PostResult();


                return response;
            }
        }
    }
}
