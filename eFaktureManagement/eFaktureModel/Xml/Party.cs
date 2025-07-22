using eFaktureModel.Xml.Utility;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace eFaktureModel.Xml
{
    public class Party
    {
        [XmlElement("EndpointID", Namespace = Namespaces.cbc)]
        public EndpointID EndpointID { get; set; }

        [XmlElement("PartyName", Namespace = Namespaces.cac)]
        public PartyName PartyName { get; set; }

        [XmlElement("PostalAddress", Namespace = Namespaces.cac)]
        public PostalAddress Address { get; set; }

        [XmlElement("PartyTaxScheme", Namespace = Namespaces.cac)]
        public TaxSchemeContainer TaxScheme { get; set; }

        [XmlElement("PartyLegalEntity", Namespace = Namespaces.cac)]
        public LegalEntity LegalEntity { get; set; }

        [XmlElement("Contact", Namespace = Namespaces.cac)]
        public Contact Contact { get; set; }
    }

   
}
