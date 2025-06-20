namespace eFaktureManagement.ApiModels.Sale
{
    public class InvoiceDto<InvoiceState>
    {
        public long invoiceId { get; set; }
        public string globUniqId { get; set; }
        public string comment { get; set; }
        public CirInvoiceStatus cirStatus { get; set; }
        public long version { get; set; }

        public DateTime lastModifiedUtc { get; set; }
        public double cirSettledAmount { get; set; }

        public string vatNumberFactoringCompany { get; set; }

        public string factoringContractNumber { get; set; }
        public string cancelComment { get; set; }
        public string stornoComment { get; set; }

        public InvoiceState status { get; set; }
    }
}
