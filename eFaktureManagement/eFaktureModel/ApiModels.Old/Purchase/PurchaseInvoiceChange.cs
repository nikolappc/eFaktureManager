namespace eFaktureManagement.ApiModels.Purchase
{
    public class PurchaseInvoiceChange
    {
        public int eventId { get; set; }
        public string date { get; set; }
        public eFaktureModel.Api.Enums.Purchase.PurchaseInvoiceStatus newInvoiceStatus { get; set; }
        public int purchaseInvoiceId { get; set; }
        public string comment { get; set; }
        public string cirInvoiceId { get; set; }
        public string subscriptionKey { get; set; }
        public string stornoNumber { get; set; }
        public eFaktureModel.Api.Enums.Cir.CirAssignmentChange cirAssignmentChange { get; set; }
        public bool isSigned { get; set; }
    }
}
