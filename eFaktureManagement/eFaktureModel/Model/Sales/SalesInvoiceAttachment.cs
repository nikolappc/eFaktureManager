using eFaktureModel.Model.Sales;

namespace eFaktureModel.Model.Purchase
{
    public class SalesInvoiceAttachment: InvoiceAttachment
    {

        public SalesInvoice Invoice
        {
            get; set;
        }   
    }
}
