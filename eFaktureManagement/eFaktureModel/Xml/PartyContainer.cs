using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class PartyContainer
    {
        [XmlElement("Party", Namespace = Namespaces.cac)]
        public Party Party { get; set; }
    }
}
