using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureModel.Api.Models;
using eFaktureModel.ApiModels.Sale;
using eFaktureSync.ApiServices;
using Microsoft.Extensions.Configuration;
using System.Net.Mime;
using System.Text.Json;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using PurchaseInvoiceDto = eFaktureModel.Api.Models.PurchaseInvoiceDto;

namespace eFaktureManagement.ApiServices
{
    public class ApiGenericInvoiceService<C, I> : IApiInvoiceService<C, I>
    {
        public string pathToChanges;
        public string pathToSingles;


        public readonly IConfiguration configRoot;

        public ApiGenericInvoiceService(IConfiguration configRoot, string pathToSingles, string pathToChanges)
        {
            this.configRoot = configRoot;
            this.pathToSingles = pathToSingles;
            this.pathToChanges = pathToChanges;
        }




        public async Task<List<C>?> GetChangesAsync(DateTime date)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new SaleChangeRequest { date = date };
                var requestData = JsonSerializer.Serialize(request);
                var requestContent = new StringContent(requestData, System.Text.Encoding.UTF8, MediaTypeNames.Application.FormUrlEncoded);

                var response = await httpClient.PostAsync(configRoot[ApiConstants.API_ROOT] + pathToChanges, requestContent);

                // Read the response
                var responseBody = await response.Content.ReadAsStringAsync();
                List<C>? list =
               JsonSerializer.Deserialize<List<C>>(responseBody);
                // Process the response data
                Console.WriteLine(responseBody);

                return list ?? new();
            }
        }


        public Task<List<long>?> GetIdsAsync(string status, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }



        public async Task<I?> GetInvoiceAsync(long invoiceId)
        {
            using (var httpClient = new HttpClient())
            {
                var baseUri = configRoot[ApiConstants.API_ROOT] + pathToSingles;
                var uriBuilder = new UriBuilder(baseUri);
                var query = HttpUtility.ParseQueryString(uriBuilder.Query);

                query["invoiceId"] = invoiceId.ToString();


                uriBuilder.Query = query.ToString();
                Uri finalUri = uriBuilder.Uri;


                var response = await httpClient.GetAsync(finalUri);

                var responseBody = await response.Content.ReadAsStringAsync();

                I? elem = JsonSerializer.Deserialize<I>(responseBody);


                return elem;
            }
        }

        public bool GetSignature(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetXmlAsync(long invoiceId)
        {
            throw new NotImplementedException();
        }

        public bool VatReverseCarge(string invoiceId, double ammount)
        {
            throw new NotImplementedException();
        }
    }
}
