
using eFaktureModel.Api.Models;

namespace eFaktureManagement.ApiServices
{
    public interface IApiPurchaseService
    {
        Task<AcceptRejectResponse?> AcceptPurchaseInvoiceAsync(int invoiceId, string comment);
        Task<AcceptRejectResponse?> RejectPurchaseInvoiceAsync(int invoiceId, string comment);
        bool GetSignature(string invoiceId);

        bool VatReverseCarge(string invoiceId, double ammount);

    }
}
