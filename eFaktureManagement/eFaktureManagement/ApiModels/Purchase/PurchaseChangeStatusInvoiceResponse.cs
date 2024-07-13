namespace eFaktureManagement.ApiModels.Purchase
{
    public abstract class PurchaseChangeStatusInvoiceResponse
    {
        public string invoiceNumber { get; set; }
        public PurchaseInvoiceStatus status { get; set; }
    }
}
