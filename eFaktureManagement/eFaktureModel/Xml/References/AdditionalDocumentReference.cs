using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.References
{
    public class AdditionalDocumentReference
    {
        [Required]
        [XmlElement(ElementName = "ID", Namespace = Namespaces.cbc)]
        public ID ID { get; set; }


    }
}