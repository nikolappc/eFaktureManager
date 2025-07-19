using eFaktureModel.Api.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model
{
    public abstract class InvoiceChange
    {
        [Key]
        public int? EventId { get; set; }

        public string Date { get; set; }



        public string? Comment { get; set; }

        public string? CirInvoiceId { get; set; }


        public string? SubscriptionKey { get; set; }

        public string? StornoNumber { get; set; }
        public CirAssignmentChange CirAssignmentChange { get; set; }
        public bool? IsSigned { get; set; }
        public bool? IsAutoAssigned { get; set; }

    }
}
