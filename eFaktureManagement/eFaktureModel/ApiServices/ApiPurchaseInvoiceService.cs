using eFaktureManagement.ApiModels.Purchase;
using eFaktureModel.Api.Models;
using eFaktureModel.ApiModels.Sale;
using eFaktureSync.ApiServices;
using Microsoft.Extensions.Configuration;
using System.Net.Mime;
using System.Text.Json;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AcceptRejectPurchaseInvoice = eFaktureModel.Api.Models.AcceptRejectPurchaseInvoice;
using PurchaseInvoiceDto = eFaktureModel.Api.Models.PurchaseInvoiceDto;

namespace eFaktureManagement.ApiServices
{
    public class ApiPurchaseInvoiceService : ApiGenericInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto>, IApiPurchaseService
    {
        public ApiPurchaseInvoiceService(IConfiguration configRoot) : base(configRoot, ApiConstants.PURCHASE_SINGLE,ApiConstants.PURCHASE_CHANGES)
        {
        }


        private async Task<AcceptRejectResponse?> AcceptRejectPurhcaseInvoiceAsync(int invoiceId, string comment, bool accepted)
        {
            using (var httpClient = new HttpClient())
            {

                var request = new AcceptRejectPurchaseInvoice
                {
                    Accepted = accepted,
                    InvoiceId = invoiceId,  
                    Comment = comment
                };
                var requestData = JsonSerializer.Serialize(request);
                var requestContent = new StringContent(requestData, System.Text.Encoding.UTF8, MediaTypeNames.Application.FormUrlEncoded);



                var response = await httpClient.PostAsync(configRoot[ApiConstants.API_ROOT] + ApiConstants.PURCHASE_ACCEPT_REJECT, requestContent);

                // Read the response
                var responseBody = await response.Content.ReadAsStringAsync();

                AcceptRejectResponse? elem = JsonSerializer.Deserialize<AcceptRejectResponse?>(responseBody);


                return elem;
            }
        }

        public async Task<AcceptRejectResponse?> AcceptPurchaseInvoiceAsync(int invoiceId, string comment)
        {
            return await AcceptRejectPurhcaseInvoiceAsync( invoiceId, comment, true);
        }


        public async Task<AcceptRejectResponse?> RejectPurchaseInvoiceAsync(int invoiceId, string comment)
        {
    

            return await AcceptRejectPurhcaseInvoiceAsync(invoiceId, comment, false);
        }

    }
}
