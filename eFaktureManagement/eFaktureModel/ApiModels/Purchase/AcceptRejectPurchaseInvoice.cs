namespace eFaktureManagement.ApiModels.Purchase
{
    public class AcceptRejectPurchaseInvoice
    {
        public int invoiceId { get; set; }
        public bool accepted { get; set; }
        public string comment { get; set; }
    }
}
