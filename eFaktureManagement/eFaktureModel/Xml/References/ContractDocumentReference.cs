using eFaktureModel.Xml.Utility;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.References
{
    public class ContractDocumentReference
    {

        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }
    }
}