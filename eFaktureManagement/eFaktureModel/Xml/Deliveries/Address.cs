using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Deliveries
{
    public class Address
    {
        [XmlElement(ElementName = "StreetName", Namespace = Namespaces.cbc)]
        public string StreetName { get; set; } // BT-75

        [XmlElement(ElementName = "AdditionalStreetName", Namespace = Namespaces.cbc)]
        public string AdditionalStreetName { get; set; } // BT-76

        [XmlElement(ElementName = "AddressLine", Namespace = Namespaces.cac)]
        public AddressLine AddressLine { get; set; } // BT-165

        [XmlElement(ElementName = "CityName", Namespace = Namespaces.cbc)]
        public string CityName { get; set; } // BT-77

        [XmlElement(ElementName = "PostalZone", Namespace = Namespaces.cbc)]
        public string PostalZone { get; set; } // BT-78

        [XmlElement(ElementName = "CountrySubentity", Namespace = Namespaces.cbc)]
        public string CountrySubentity { get; set; } // BT-79

        [XmlElement(ElementName = "Country", Namespace = Namespaces.cac)]
        public Country Country { get; set; } // BT-80
    }


}
