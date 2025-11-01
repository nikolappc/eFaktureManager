using eFaktureManagement.ApiModels.Purchase;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.Api.Models.Vat;
using eFaktureModel.ApiModels.Sale;
using eFaktureModel.ApiServices.Util;
using eFaktureModel.Enums;
using eFaktureSync.ApiServices;
using Microsoft.Extensions.Configuration;
using System.Net.Mime;
using System.Text.Json;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AcceptRejectPurchaseInvoice = eFaktureModel.Api.Models.Purchase.AcceptRejectPurchaseInvoice;
using PurchaseInvoiceDto = eFaktureModel.Api.Models.Purchase.PurchaseInvoiceDto;

namespace eFaktureManagement.ApiServices
{
    public class ApiPurchaseInvoiceService : ApiGenericInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto>, IApiPurchaseService
    {
        public ApiPurchaseInvoiceService(IConfiguration configRoot) : base(configRoot, PurchaseApiPaths.Paths)
        {
        }


        private async Task<AcceptRejectResponse?> AcceptRejectPurhcaseInvoiceAsync(long invoiceId, string comment, bool accepted)
        {
            using (var httpClient = new HttpClientBuilder<AcceptRejectResponse?>(configRoot))
            {

                var request = new AcceptRejectPurchaseInvoice
                {
                    Accepted = accepted,
                    InvoiceId = invoiceId,  
                    Comment = comment
                };
                httpClient
                    .AddPath(PurchaseApiPaths.Paths[EApiPaths.PURCHASE_ACCEPT_REJECT])
                    .AddHttpContentBody(request);

                var response = await httpClient.PostResult();

             
                return response.Result;
            }
        }

        public async Task<AcceptRejectResponse?> AcceptPurchaseInvoiceAsync(long invoiceId, string comment)
        {
            return await AcceptRejectPurhcaseInvoiceAsync( invoiceId, comment, true);
        }


        public async Task<AcceptRejectResponse?> RejectPurchaseInvoiceAsync(long invoiceId, string comment)
        {
            return await AcceptRejectPurhcaseInvoiceAsync(invoiceId, comment, false);
        }

        public async Task<bool> VatReverseCarge(long invoiceId, double ammount)
        {
            using (var httpClient = new HttpClientBuilder(configRoot))
            {

                var request = new VatReverseChargeDto
                {
                    PurchaseInvoiceId=invoiceId,
                    VatAmount = ammount
                };
                httpClient
                    .AddPath(PurchaseApiPaths.Paths[EApiPaths.VAT_REV_CHRG])
                    .AddHttpContentBody(request);

                var response = await httpClient.PostResult();


                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
        }
    }
}
