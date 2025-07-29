using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Payment
{
    public class PayerFinancialAccount
    {
        [XmlElement(ElementName = "ID", Namespace = Namespaces.cbc)]
        public string DebitedAccountID { get; set; } // BT-91
    }
}
