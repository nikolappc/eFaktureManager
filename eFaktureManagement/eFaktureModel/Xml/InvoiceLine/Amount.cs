using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.InvoiceLines
{
    public class Amount
    {
        [XmlAttribute("currencyID")]
        public string Currency { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }


}
