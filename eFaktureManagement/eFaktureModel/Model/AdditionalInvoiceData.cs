using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model
{
    public class AdditionalInvoiceData
    {
        public long InvoiceId { get; set; }

        public InvoiceDirectionEnum InvoiceDirection { get; set; }  


        public decimal? TotalAmount { get; set; }   

        public decimal? TotalVat { get; set; }  

        public decimal? TotalAmountWithVat { get; set; }    

        public decimal? TotalAmountWithoutVat { get; set; } 


    }
}
