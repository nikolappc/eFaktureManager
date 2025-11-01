using eFaktureModel.Api.Models.Purchase;
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

    [Table(nameof(PurchaseInvoice))]

    public class PurchaseInvoice : Invoice
    {

        public PurchaseInvoiceStatus Status { get; set; }


    }
}

