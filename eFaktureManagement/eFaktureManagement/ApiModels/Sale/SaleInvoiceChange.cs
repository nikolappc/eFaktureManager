
namespace eFaktureManagement.ApiModels.Sale
{
    public class SaleInvoiceChange
    {
        public int eventId { get; set; }
        public string date { get; set; }
        public SaleInvoiceStatus newInvoiceStatus { get; set; }
        public int salesInvoiceId { get; set; }
        public string comment { get; set; }
        public string cirInvoiceId { get; set; }
        public string subscriptionKey { get; set; }
        public string stornoNumber { get; set; }
        public CirAssignmentChange cirAssignmentChange { get; set; }
        public bool isSigned { get; set; }
    }
}
