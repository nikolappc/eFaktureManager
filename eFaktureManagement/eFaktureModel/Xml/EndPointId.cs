using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class EndpointID
    {
        [XmlAttribute("schemeID")]
        public string SchemeID { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
