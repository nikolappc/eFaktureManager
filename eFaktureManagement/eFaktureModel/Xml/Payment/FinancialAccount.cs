using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Payment
{
    public class FinancialAccount
    {
        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string AccountID { get; set; }
    }


}
