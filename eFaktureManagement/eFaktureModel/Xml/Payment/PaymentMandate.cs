using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Payment
{
    public class PaymentMandate
    {
        [XmlElement(ElementName = "ID", Namespace = Namespaces.cbc)]
        public string MandateReferenceID { get; set; }

        [XmlElement(ElementName = "PayerFinancialAccount", Namespace = Namespaces.cac)]
        public PayerFinancialAccount PayerFinancialAccount { get; set; }
    }

  
}
