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
    public abstract class AApiPurchaseInvoiceService<C, I> : ApiGenericInvoiceService<C, I>
    {
        protected AApiPurchaseInvoiceService(IConfiguration configRoot, Dictionary<EApiPaths, string> pathsConfirguration) : base(configRoot, pathsConfirguration)
        {
        }
        public abstract Task<AcceptRejectResponse?> AcceptPurchaseInvoiceAsync(long invoiceId, string? comment);
        public abstract Task<AcceptRejectResponse?> RejectPurchaseInvoiceAsync(long invoiceId, string? comment);

        public abstract Task<bool> VatReverseCarge(long invoiceId, double ammount);
    }
}
