using eFaktureModel.Api.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model
{
    public abstract class Invoice
    {


        [Key]
        public long InvoiceId { get; set; }


        public Guid GlobUniqId { get; set; }

        public string? Comment { get; set; }

        public eFaktureModel.Api.Models.CirInvoiceStatus CirStatus { get; set; }

        public string CirInvoiceId { get; set; }

        public DateTime? LastModifiedUtc { get; set; }


        public double? CirSettledAmount { get; set; }

        public string VatNumberFactoringCompany { get; set; }

        public string FactoringContractNumber { get; set; }


        public string? CancelComment { get; set; }

        public string? StornoComment { get; set; }


    }
}
