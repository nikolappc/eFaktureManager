using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.InvoiceLines
{

    public class Quantity
    {
        [XmlAttribute("unitCode")]
        public string UnitCode { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }


}
