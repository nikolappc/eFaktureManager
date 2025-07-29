using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Payment
{

    public class FinancialInstitutionBranch
    {
        [XmlElement(ElementName = "ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }  // BT-86: Payment service provider identifier
    }


}
