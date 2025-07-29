using eFaktureModel.Xml.Tax;
using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Allowance
{

    public class AllowanceCharge
    {
        [XmlElement(ElementName = "ChargeIndicator", Namespace = Namespaces.cbc)]
        public bool ChargeIndicator { get; set; } = false; // Must be false for allowance

        [XmlElement(ElementName = "Amount", Namespace = Namespaces.cbc)]
        [Required]
        public decimal Amount { get; set; } // BT-92

        [XmlElement(ElementName = "BaseAmount", Namespace = Namespaces.cbc)]
        public decimal? BaseAmount { get; set; } // BT-93

        [XmlElement(ElementName = "MultiplierFactorNumeric", Namespace = Namespaces.cbc)]
        [Range(0, 1)]
        public decimal? MultiplierFactorNumeric { get; set; } // BT-94

        [XmlElement(ElementName = "TaxCategory", Namespace = Namespaces.cac)]
        [Required]
        public TaxCategory TaxCategory { get; set; } // BT-95/BT-96

        [XmlElement(ElementName = "AllowanceChargeReason", Namespace = Namespaces.cbc)]
        public string AllowanceChargeReason { get; set; } // BT-97

        [XmlElement(ElementName = "AllowanceChargeReasonCode", Namespace = Namespaces.cbc)]
        public string AllowanceChargeReasonCode { get; set; } // BT-98
    }



}
