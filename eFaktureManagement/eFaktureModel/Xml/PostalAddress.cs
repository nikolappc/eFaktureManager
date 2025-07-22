using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class PostalAddress
    {
        [XmlElement("StreetName", Namespace = Namespaces.cbc)]
        public string StreetName { get; set; }

        [XmlElement("CityName", Namespace = Namespaces.cbc)]
        public string CityName { get; set; }

        [XmlElement("PostalZone", Namespace = Namespaces.cbc)]
        public string PostalZone { get; set; }

        [XmlElement("Country", Namespace = Namespaces.cac)]
        public Country Country { get; set; }
    }

}
