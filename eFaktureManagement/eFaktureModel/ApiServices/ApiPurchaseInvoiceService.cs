using eFaktureManagement.ApiModels.Purchase;
using eFaktureModel.Api.Config;
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
    public class ApiPurchaseInvoiceService : AApiPurchaseInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto>
    {
        public ApiPurchaseInvoiceService(IConfiguration configRoot, EFaktureApiRoot pathsConfirguration) : base(configRoot, pathsConfirguration)
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
                    .AddPath(PathsConfiguration.Endpoints[EApiPaths.ACCEPT_REJECT])
                    .AddHttpContentBody(request);

                var response = await httpClient.PostResult();

             
                return response.Result;
            }
        }

        public override async Task<AcceptRejectResponse?> AcceptPurchaseInvoiceAsync(long invoiceId, string comment)
        {
            return await AcceptRejectPurhcaseInvoiceAsync( invoiceId, comment, true);
        }


        public override  async Task<AcceptRejectResponse?> RejectPurchaseInvoiceAsync(long invoiceId, string comment)
        {
            return await AcceptRejectPurhcaseInvoiceAsync(invoiceId, comment, false);
        }

        public override async Task<bool> VatReverseCarge(long invoiceId, double ammount)
        {
            using (var httpClient = new HttpClientBuilder(configRoot))
            {

                var request = new VatReverseChargeDto
                {
                    PurchaseInvoiceId=invoiceId,
                    VatAmount = ammount
                };
                httpClient
                    .AddPath(PathsConfiguration.Endpoints[EApiPaths.VAT_REV_CHRG])
                    .AddHttpContentBody(request);

                var response = await httpClient.PostResult();


                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
        }

        protected override EApiSections GetSection()
        {
            return EApiSections.PURCHASE;
        }
    }
}
