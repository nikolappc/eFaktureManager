
namespace eFaktureManagement.ApiModels.Sale
{
    public abstract class SaleChangeStatusInvoiceResponse
    {
        public string invoiceNumber { get; set; }
        public SaleInvoiceStatus status { get; set; }
    }
}
