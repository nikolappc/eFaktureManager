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
    public class PaymentMeans
    {
        [XmlElement("PaymentMeansCode", Namespace = Namespaces.cbc)]
        public string Code { get; set; }

        [XmlElement("PayeeFinancialAccount", Namespace = Namespaces.cac)]
        public FinancialAccount Account { get; set; }
    }


}
