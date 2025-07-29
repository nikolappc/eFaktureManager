using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Payment
{
    public class CardAccount
    {
        [XmlElement(ElementName = "PrimaryAccountNumberID", Namespace = Namespaces.cbc)]
        [Required]
        [StringLength(19, MinimumLength = 12, ErrorMessage = "Broj kartice mora biti izma")]
        [RegularExpression(@"^\d{12,19}$", ErrorMessage = "Card number must contain only digits")]
        public string PrimaryAccountNumberID { get; set; } 

        [XmlElement(ElementName = "HolderName", Namespace = Namespaces.cbc)]
        public string HolderName { get; set; } 
    }
}
