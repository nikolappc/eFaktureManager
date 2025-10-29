using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.InvoiceLines
{
    public class ItemProperty
    {
        [XmlElement(ElementName = "Name", Namespace = Namespaces.cbc)]
        public string Name { get; set; }

        [XmlElement(ElementName = "Value", Namespace = Namespaces.cbc)]
        public string Value { get; set; }
    }


}
