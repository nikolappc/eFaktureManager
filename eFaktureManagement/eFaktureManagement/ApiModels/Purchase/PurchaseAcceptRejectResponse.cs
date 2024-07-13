using eFaktureManagement.ApiModels.Purchase;

namespace eFaktureManagement.ApiModels
{
    public  class PurchaseAcceptRejectResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string httpStatus { get; set; }

        public PurchaseChangeStatusInvoiceResponse invoice { get; set; }

    }
}
