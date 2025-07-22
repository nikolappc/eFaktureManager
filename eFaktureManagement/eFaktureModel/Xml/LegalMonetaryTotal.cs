using eFaktureModel.Xml.InvoiceLines;
using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class LegalMonetaryTotal
    {
        [XmlElement("LineExtensionAmount", Namespace = Namespaces.cbc)]
        public Amount LineExtensionAmount { get; set; }

        [XmlElement("TaxExclusiveAmount", Namespace = Namespaces.cbc)]
        public Amount TaxExclusiveAmount { get; set; }

        [XmlElement("TaxInclusiveAmount", Namespace = Namespaces.cbc)]
        public Amount TaxInclusiveAmount { get; set; }

        [XmlElement("AllowanceTotalAmount", Namespace = Namespaces.cbc)]
        public Amount AllowanceTotalAmount { get; set; }

        [XmlElement("PrepaidAmount", Namespace = Namespaces.cbc)]
        public Amount PrepaidAmount { get; set; }

        [XmlElement("PayableRoundingAmount", Namespace = Namespaces.cbc)]
        public Amount RoundingAmount { get; set; }

        [XmlElement("PayableAmount", Namespace = Namespaces.cbc)]
        public Amount PayableAmount { get; set; }
    }
}
