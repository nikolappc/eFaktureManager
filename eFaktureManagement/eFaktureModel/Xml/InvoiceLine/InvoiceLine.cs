using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.InvoiceLines
{
    public class InvoiceLine
    {
        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }

        [XmlElement("InvoicedQuantity", Namespace = Namespaces.cbc)]
        public Quantity Quantity { get; set; }

        [XmlElement("LineExtensionAmount", Namespace = Namespaces.cbc)]
        public Amount LineExtensionAmount { get; set; }

        [XmlElement("Item", Namespace = Namespaces.cac)]
        public Item Item { get; set; }

        [XmlElement("Price", Namespace = Namespaces.cac)]
        public Price Price { get; set; }
    }


}
