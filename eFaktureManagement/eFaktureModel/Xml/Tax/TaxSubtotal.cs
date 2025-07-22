using eFaktureModel.Xml.InvoiceLines;
using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Tax
{
    public class TaxSubtotal
    {
        [XmlElement("TaxableAmount", Namespace = Namespaces.cbc)]
        public Amount TaxableAmount { get; set; }

        [XmlElement("TaxAmount", Namespace = Namespaces.cbc)]
        public Amount TaxAmount { get; set; }

        [XmlElement("TaxCategory", Namespace = Namespaces.cac)]
        public TaxCategory TaxCategory { get; set; }
    }


}
