namespace eFaktureManagement.ApiModels
{
    public class MiniInvoiceDto
    {
        public long invoiceId { get; set; }
        public long purchaseInvoiceId { get; set; }
        public long salesInvoiceId { get; set; }
    }
}
