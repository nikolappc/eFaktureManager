using eFaktureModel.Xml.Payment;
using eFaktureModel.Xml.Tax;
using eFaktureModel.Xml.InvoiceLines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using eFaktureModel.Xml.Utility;

namespace eFaktureModel.Xml
{
    [XmlRoot("Invoice", Namespace = Namespaces.Invoice)]
    public class Invoice
    {
        [XmlElement("CustomizationID", Namespace = Namespaces.cbc)]
        public string CustomizationID { get; set; }

        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }

        [XmlElement("IssueDate", Namespace = Namespaces.cbc)]
        public DateTime IssueDate { get; set; }

        [XmlElement("DueDate", Namespace = Namespaces.cbc)]
        public DateTime DueDate { get; set; }

        [XmlElement("InvoiceTypeCode", Namespace = Namespaces.cbc)]
        public string InvoiceTypeCode { get; set; }

        [XmlElement("Note", Namespace = Namespaces.cbc)]
        public string Note { get; set; }

        [XmlElement("DocumentCurrencyCode", Namespace = Namespaces.cbc)]
        public string Currency { get; set; }

        [XmlElement("InvoicePeriod", Namespace = Namespaces.cac)]
        public InvoicePeriod InvoicePeriod { get; set; }

        [XmlElement("AccountingSupplierParty", Namespace = Namespaces.cac)]
        public PartyContainer AccountingSupplierParty { get; set; }

        [XmlElement("AccountingCustomerParty", Namespace = Namespaces.cac)]
        public PartyContainer AccountingCustomerParty { get; set; }

        [XmlElement("PaymentMeans", Namespace = Namespaces.cac)]
        public PaymentMeans PaymentMeans { get; set; }

        [XmlElement("TaxTotal", Namespace = Namespaces.cac)]
        public TaxTotal TaxTotal { get; set; }

        [XmlElement("LegalMonetaryTotal", Namespace = Namespaces.cac)]
        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }

        [XmlElement("InvoiceLine", Namespace = Namespaces.cac)]
        public InvoiceLine InvoiceLine { get; set; }
    }
}
