using eFaktureModel.Xml.InvoiceLines;
using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class LegalMonetaryTotal
    {
        [Required]
        [XmlElement("LineExtensionAmount", Namespace = Namespaces.cbc)]
        public Amount LineExtensionAmount { get; set; }

        [Required]
        [XmlElement("TaxExclusiveAmount", Namespace = Namespaces.cbc)]
        public Amount TaxExclusiveAmount { get; set; }

        [XmlElement(ElementName = "ChargeTotalAmount", Namespace = Namespaces.cbc)]
        public decimal? ChargeTotalAmount { get; set; }

        [Required]
        [XmlElement("TaxInclusiveAmount", Namespace = Namespaces.cbc)]
        public Amount TaxInclusiveAmount { get; set; }

        [XmlElement("AllowanceTotalAmount", Namespace = Namespaces.cbc)]
        public Amount AllowanceTotalAmount { get; set; }

        [XmlElement("PrepaidAmount", Namespace = Namespaces.cbc)]
        public Amount PrepaidAmount { get; set; }

        [XmlElement("PayableRoundingAmount", Namespace = Namespaces.cbc)]
        public Amount RoundingAmount { get; set; }
        [Required]
        [XmlElement("PayableAmount", Namespace = Namespaces.cbc)]
        public Amount PayableAmount { get; set; }
    }
}
