
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace eFaktureModel.Api.Models.Purchase
{

    public class AcceptRejectPurchaseInvoiceDto
    {

        [Required]
        public long InvoiceId { get; set; }
        [Required]
        public bool Accepted { get; set; }

        public string? Comment { get; set; }

    }
}
