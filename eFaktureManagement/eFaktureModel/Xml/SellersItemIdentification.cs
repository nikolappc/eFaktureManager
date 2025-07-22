using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class SellersItemIdentification
    {
        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }
    }
}
