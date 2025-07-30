using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.InvoiceLines
{
    public class Price
    {
        [XmlElement("PriceAmount", Namespace = Namespaces.cbc)]
        public Amount PriceAmount { get; set; }
        [XmlElement(ElementName = "BaseQuantity", Namespace = Namespaces.cbc)]
        public Quantity BaseQuantity { get; set; }

        [XmlElement(ElementName = "AllowanceCharge", Namespace = Namespaces.cac)]
        public PriceDiscount PriceDiscount { get; set; }
    }



}
