
using eFaktureModel.Api.Models;

namespace eFaktureManagement.ApiServices
{
    public interface IApiPurchaseService
    {
        Task<AcceptRejectResponse?> AcceptPurchaseInvoiceAsync(int invoiceId, string comment);
        Task<AcceptRejectResponse?> RejectPurchaseInvoiceAsync(int invoiceId, string comment);
        bool GetSignature(string invoiceId);

        bool VatReverseCarge(string invoiceId, double ammount);


        //TODO

        // GET /api/publicApi/purchase-invoice/ubl/{cirInvoiceId}

        // POST /api/publicApi/purchase-invoice/{cirInvoiceId}/assign

        // GET /api/publicApi/purchase-invoice/{cirInvoiceId}/cancelassign

        // POST /api/publicApi/purchase-invoice/acceptRejectPurchaseInvoiceByCirInvoiceId

        // GET /api/publicApi/purchase-cir-invoice/getPurchaseInvoiceAssignationHistory/{cirInvoiceId}

        // GET /api/publicApi/purchase-cir-invoice/getInvoicePaymentsAndHistory/{cirInvoiceId}


    }
}
