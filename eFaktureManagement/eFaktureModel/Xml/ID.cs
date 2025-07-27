using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class ID
    {
        [XmlText]
        public string Value { get; set; }

        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
    }


}
