using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [XmlElement(ElementName = "InstructionNote", Namespace = Namespaces.cbc)]
        [StringLength(200)]
        public string InstructionNote { get; set; } // BT: Payment means text

        [XmlElement(ElementName = "PaymentID", Namespace = Namespaces.cbc)]
        [RegularExpression(@"^(\(mod\d{2,}\)\s)?[\dA-Za-z\-\/]+$", ErrorMessage = "Must match remittance format, e.g. (mod97) 12345678")]
        public string PaymentID { get; set; } // BT-83 Remittance information


        [XmlElement(ElementName = "CardAccount", Namespace = Namespaces.cac)]
        public CardAccount CardAccount { get; set; }
        [XmlElement(ElementName = "PaymentMandate", Namespace = Namespaces.cac)]
        public PaymentMandate PaymentMandate { get; set; }
    }



}


}
