using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.References
{
    public class OrderLineReference
    {
        [XmlElement(ElementName = "LineID", Namespace = Namespaces.cbc)]
        public string LineID { get; set; }
    }


}
