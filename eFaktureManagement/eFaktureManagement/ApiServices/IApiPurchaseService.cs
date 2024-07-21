using eFaktureManagement.ApiModels;

namespace eFaktureManagement.ApiServices
{
    public interface IApiPurchaseService
    {
        PurchaseAcceptRejectResponse AcceptPurhcaseInvoice(string invoiceId, string comment);
        bool GetSignature(string invoiceId);

        bool VatReverseCarge(string invoiceId, double ammount);

    }
}
