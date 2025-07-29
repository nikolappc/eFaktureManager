using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Deliveries
{
    public class AddressLine
    {
        [XmlElement(ElementName = "Line", Namespace = Namespaces.cbc)]
        public string Line { get; set; }
    }


}
