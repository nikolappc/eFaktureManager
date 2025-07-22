using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class TaxScheme
    {
        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }
    }


}
