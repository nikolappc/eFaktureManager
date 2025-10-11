using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureManagement.ApiModels.Sale;
using eFaktureModel.Api.Models;
using eFaktureModel.ApiModels.Sale;
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

        public ApiSaleInvoiceService(IConfiguration configRoot) : base(configRoot, ApiConstants.SALES_SINGLE, ApiConstants.SALES_CHANGES)
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

        public async Task<MiniInvoiceDto?>  ImportUbl(string requestId, bool sendToCir, bool executeValidation, string xml)
        {
            using (var httpClient = new HttpClient())
            {

                var xmlContent = new StringContent(xml, Encoding.UTF8, "application/xml");




                var queryParams = new Dictionary<string, string?>
                {
                    { "requestId", requestId },
                    { "sendToCir", sendToCir.ToString() },
                    { "executeValidation", executeValidation.ToString() }
                };


                var fullUrl = QueryHelpers.AddQueryString(configRoot[ApiConstants.API_ROOT] + "/api/publicApi/sales-invoice/ubl", queryParams);


                var response = await httpClient.PostAsync(fullUrl, xmlContent);

                // Read the response
                var responseBody = await response.Content.ReadAsStringAsync();
                MiniInvoiceDto? resultingInvoice =
               JsonSerializer.Deserialize<MiniInvoiceDto?>(responseBody);
                // Process the response data


                return resultingInvoice;
            }
        }

        public Task<InvoiceDto> Storno(long invoideId, string stornoNumber, string stornoComment)
        {
            throw new NotImplementedException();
        }

        public async Task<MiniInvoiceDto?> UploadUbl(string requestId, bool sendToCir, bool executeValidation, byte[] xml)
        {
            using (var httpClient = new HttpClient())
            {

                //Add file to request
                var fileContent = new ByteArrayContent(xml);
                fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/xml");

                var multipartContent = new MultipartFormDataContent();
                multipartContent.Add(fileContent, "ubl", "invoice.xml");



                var queryParams = new Dictionary<string, string?>
                {
                    { "requestId", requestId },
                    { "sendToCir", sendToCir.ToString() },
                    { "executeValidation", executeValidation.ToString() }
                };


                var fullUrl = QueryHelpers.AddQueryString(configRoot[ApiConstants.API_ROOT] + "/api/publicApi/sales-invoice/ubl/upload", queryParams);


                var response = await httpClient.PostAsync(fullUrl, multipartContent);

                // Read the response
                var responseBody = await response.Content.ReadAsStringAsync();
                MiniInvoiceDto? resultingInvoice =
               JsonSerializer.Deserialize<MiniInvoiceDto?>(responseBody);
                // Process the response data


                return resultingInvoice;
            }
        }
    }
}
