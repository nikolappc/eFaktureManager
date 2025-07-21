using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model.Purchase
{
    public class PurchaseInvoiceAttachment: InvoiceAttachment
    {

        public PurchaseInvoice Invoice
        {
            get; set;
        }   
    }
}
