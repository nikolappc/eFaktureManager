using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.InvoiceLines
{
    public class PriceDiscount
    {
        [XmlElement(ElementName = "ChargeIndicator", Namespace = Namespaces.cbc)]
        public bool ChargeIndicator { get; set; } = false;

        [XmlElement(ElementName = "Amount", Namespace = Namespaces.cbc)]
        public decimal? Amount { get; set; }

        [XmlElement(ElementName = "BaseAmount", Namespace = Namespaces.cbc)]
        public decimal? BaseAmount { get; set; }
    }


}
