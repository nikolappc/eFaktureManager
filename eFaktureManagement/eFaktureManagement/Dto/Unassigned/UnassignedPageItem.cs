using eFaktureModel.Api.Models;

namespace eFaktureManagement.Dto.Unassigned
{
    public class UnassignedPageItem
    {
        public PurchaseInvoiceStatus Status { get; set; }
        public DateTime? LastModifiedUtc { get; set; }
        public long InvoiceId { get; set; }
    }
}
