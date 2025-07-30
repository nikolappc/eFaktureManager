using eFaktureModel.Xml.Utility;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.References
{
    public class IDReference
    {

        [XmlElement("ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }
    }
}