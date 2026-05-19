using eFaktureModel.Api.Enums.Purchase;
using eFaktureModel.Model.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model.Purchase
{
    [Table(nameof(PurchaseInvoiceChange))]

    public class PurchaseInvoiceChange : InvoiceChange
    {

        [ForeignKey("PurchaseInvoice")]
        public long PurchaseInvoiceId { get; set; }
        public PurchaseInvoiceStatus NewInvoiceStatus { get; set; }

        public PurchaseInvoice PurchaseInvoice { get; set; }
    }
}
