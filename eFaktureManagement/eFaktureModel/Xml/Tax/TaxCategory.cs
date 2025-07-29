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
    public class TaxCategory
    {
        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }

        [XmlElement("Percent", Namespace = Namespaces.cbc)]
        public decimal Percent { get; set; }

        [XmlElement(ElementName = "TaxExemptionReason", Namespace = Namespaces.cbc)]
        public string TaxExemptionReason { get; set; }

        [XmlElement(ElementName = "TaxExemptionReasonCode", Namespace = Namespaces.cbc)]
        public string TaxExemptionReasonCode { get; set; }




        [XmlElement("TaxScheme", Namespace = Namespaces.cac)]
        public TaxScheme TaxScheme { get; set; }
    }


}
