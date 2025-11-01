using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureManagement.ApiModels.Sale;
using eFaktureModel.Api.Models;
using eFaktureModel.Api.Models.Invoices;
using eFaktureModel.Api.Models.Sales;
using eFaktureModel.Api.Models.Vat;
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
using MiniInvoiceDto = eFaktureModel.Api.Models.Invoices.MiniInvoiceDto;

namespace eFaktureManagement.ApiServices
{
    public class ApiSaleInvoiceService : ApiGenericInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>, IApiSalesService
    {

        public ApiSaleInvoiceService(IConfiguration configRoot) : base(configRoot, SalesApiPaths.Paths)
        {
        }

        public async Task<InvoiceDto?> CancelDraft(long invoideId, string cancelComment)
        {
            using (var httpClient = new HttpClientBuilder<InvoiceDto?>(configRoot))
            {

                var body = new CancelInvoiceMessageDto
                {
                    InvoiceId = invoideId,
                    CancelComments = cancelComment
                };  

                httpClient

                    .AddPath(PathsConfirguration[EApiPaths.CANCEL])
                    .AddHttpContentBody(body);

                var response = await httpClient.PostResult();

                return response.Result;
            }
        }

        public async Task<long?> DeleteDraft(long invoiceId)
        {
            using (var httpClient = new HttpClientBuilder<long?>(configRoot))
            {

                httpClient

                    .AddPath(PathsConfirguration[EApiPaths.SINGLE])
                    .AddPathParam(invoiceId);

                var response = await httpClient.DeleteResult();

                return response.Result;
            }
        }

        public async Task<List<long>?> DeleteDrafts(List<long> invoiceIds)
        {
            using (var httpClient = new HttpClientBuilder<List<long>?>(configRoot))
            {

                httpClient

                    .AddPath(PathsConfirguration[EApiPaths.SINGLE])
                    .AddHttpContentBody(invoiceIds);

                var response = await httpClient.DeleteResult();

                return response.Result;
            }
        }

        public async Task<ValueAddedTaxExemptionReasonDto?> GetValueAddedTaxExemptionReasonList()
        {
            using (var httpClient = new HttpClientBuilder<ValueAddedTaxExemptionReasonDto?>(configRoot))
            {

                httpClient
                    .AddPath(PathsConfirguration[EApiPaths.VAT_EXEMPTIONS]);

                var response = await httpClient.GetResult();

                return response.Result;
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

                return response.Result;
            }
        }

        public async Task<InvoiceDto?> Storno(long invoideId, string stornoNumber, string stornoComment)
        {
            using (var httpClient = new HttpClientBuilder<InvoiceDto?>(configRoot))
            {
                var body = new StornoInvoiceMessageDto
                {
                    InvoiceId = invoideId,
                    StornoComment = stornoComment,
                    StornoNumber = stornoNumber
                };  
                httpClient
                    .AddPath(PathsConfirguration[EApiPaths.STORNO])
                    .AddHttpContentBody(body);

                var response = await httpClient.PostResult();

                return response.Result;
            }
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


                return response.Result  ;
            }
        }
    }
}
