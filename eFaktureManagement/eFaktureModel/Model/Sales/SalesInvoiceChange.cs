using eFaktureModel.Api.Models;
using eFaktureModel.Model.Purchase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model.Sales
{
    [Table(nameof(SalesInvoiceChange))] 
    public class SalesInvoiceChange:InvoiceChange
    {

        [ForeignKey("SalesInvoice")]
        public long SalesInvoiceId { get; set; }

        public PurchaseInvoice SalesInvoice { get; set; }

    }
}
