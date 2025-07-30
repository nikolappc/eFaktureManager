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
using System.ComponentModel.DataAnnotations;
using eFaktureModel.Xml.References;
using eFaktureModel.Xml.Deliveries;
using eFaktureModel.Xml.Charges;

namespace eFaktureModel.Xml
{
    [XmlRoot("Invoice", Namespace = Namespaces.Invoice)]
    public class Invoice
    {

        //1-1
        [Required]
        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }
        //1-1
        [Required]
        [XmlElement("IssueDate", Namespace = Namespaces.cbc)]
        public DateTime IssueDate { get; set; }
        //1-1
        [Required]
        [XmlElement("InvoiceTypeCode", Namespace = Namespaces.cbc)]
        public string InvoiceTypeCode { get; set; }
        //0-1
        [XmlElement("DocumentCurrencyCode", Namespace = Namespaces.cbc)]
        public string? Currency { get; set; }
        //0-1
        [XmlElement("DescriptionCode", Namespace = Namespaces.cbc)]
        public string? DescriptionCode { get; set; }

        //0-1   
        [XmlElement("DueDate", Namespace = Namespaces.cbc)]
        public DateTime? DueDate { get; set; }

        //0-1   
        [XmlElement("BuyerReference", Namespace = Namespaces.cbc)]
        public string? BuyerReference { get; set; }

        //0-1   
        [XmlElement("ProjectReference", Namespace = Namespaces.cac)]
        public IDReference? ProjectReference { get; set; }

        //0-1
        [XmlElement("ContractDocumentReference", Namespace = Namespaces.cac)]
        public IDReference? ContractDocumentReference { get; set; } = new IDReference();

        //0-1   
        [XmlElement("OrderReference", Namespace = Namespaces.cac)]
        public OrderReference? OrderReference { get; set; }

        [XmlElement("ReceiptDocumentReference", Namespace = Namespaces.cac)]
        public IDReference? ReceiptDocumentReference { get; set; }

        [XmlElement("DespatchDocumentReference", Namespace = Namespaces.cac)]
        public IDReference? DespatchDocumentReference { get; set; }

        [XmlElement("OriginatorDocumentReference", Namespace = Namespaces.cac)]
        public OriginatorDocumentReference? OriginatorDocumentReference { get; set; }

        [XmlElement("AdditionalDocumentReference", Namespace = Namespaces.cac)]
        public AdditionalDocumentReference? AdditionalDocumentReference { get; set; }
        [XmlElement(ElementName = "AccountingCost", Namespace = Namespaces.cbc)]
        public string? AccountingCost { get; set; }


        [XmlElement(ElementName = "PaymentTerms", Namespace = Namespaces.cac)]
        public PaymentTerms? PaymentTerms { get; set; }

        [XmlElement("Note", Namespace = Namespaces.cbc)]
        public string? Note { get; set; }
        [XmlElement(ElementName = "ProfileID", Namespace = Namespaces.cbc)]
        public string ProfileID { get; set; }
        [Required]
        [XmlElement("CustomizationID", Namespace = Namespaces.cbc)]
        public string CustomizationID { get; set; }


        [XmlElement(ElementName = "BillingReference", Namespace = Namespaces.cac)]
        public List<BillingReference> BillingReferences { get; set; }
        [Required]
        [XmlElement("AccountingSupplierParty", Namespace = Namespaces.cac)]
        public PartyContainer AccountingSupplierParty { get; set; }
        [Required]
        [XmlElement("AccountingCustomerParty", Namespace = Namespaces.cac)]
        public PartyContainer AccountingCustomerParty { get; set; }


        [XmlElement("PayeeParty", Namespace = Namespaces.cac)]
        public PartyContainer? PayeeParty { get; set; }

        [Required]
        [XmlElement("TaxRepresentativeParty", Namespace = Namespaces.cac)]
        public PartyContainer TaxRepresentativeParty { get; set; }

        [XmlElement(ElementName = "Delivery", Namespace = Namespaces.cac)]
        public Delivery? Delivery { get; set; }

        [XmlElement("InvoicePeriod", Namespace = Namespaces.cac)]
        public InvoicePeriod InvoicePeriod { get; set; }


        [XmlElement("PaymentMeans", Namespace = Namespaces.cac)]
        public PaymentMeans PaymentMeans { get; set; }
        // 0..n
        [XmlElement(ElementName = "AllowanceCharge", Namespace = Namespaces.cac)]
        public List<AllowanceCharge> AllowanceCharges { get; set; }

        [XmlElement("LegalMonetaryTotal", Namespace = Namespaces.cac)]
        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }

        [XmlElement("TaxTotal", Namespace = Namespaces.cac)]
        public TaxTotal TaxTotal { get; set; }
            [XmlElement("InvoiceLine", Namespace = Namespaces.cac)]
        public InvoiceLine InvoiceLine { get; set; }

        //TODO CONTINUE 


        [XmlElement("TaxCurrencyCode", Namespace = Namespaces.cbc)]
        public string TaxCurrencyCode { get; set; }









    }
}
