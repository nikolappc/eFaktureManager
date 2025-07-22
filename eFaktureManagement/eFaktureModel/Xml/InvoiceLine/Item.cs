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
    public class Item
    {
        [XmlElement("Name", Namespace = Namespaces.cbc)]
        public string Name { get; set; }

        [XmlElement("SellersItemIdentification", Namespace = Namespaces.cac)]
        public SellersItemIdentification SellersItemIdentification { get; set; }

        [XmlElement("ClassifiedTaxCategory", Namespace = Namespaces.cac)]
        public ClassifiedTaxCategory ClassifiedTaxCategory { get; set; }
    }


}
