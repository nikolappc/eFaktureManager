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
    public class TaxSchemeContainer
    {
        [XmlElement("CompanyID", Namespace = Namespaces.cbc)]
        public string CompanyID { get; set; }

        [XmlElement("TaxScheme", Namespace = Namespaces.cac)]
        public TaxScheme TaxScheme { get; set; }
    }

}
