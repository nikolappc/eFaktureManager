using eFaktureModel.Xml.Tax;
using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class ClassifiedTaxCategory
    {
        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }

        [XmlElement("Percent", Namespace = Namespaces.cbc)]
        public decimal Percent { get; set; }

        [XmlElement("TaxScheme", Namespace = Namespaces.cac)]
        public TaxScheme TaxScheme { get; set; }
    }
}
