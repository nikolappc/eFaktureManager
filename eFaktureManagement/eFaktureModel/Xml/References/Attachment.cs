using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.References
{
    public class Attachment
    {
        [XmlElement(ElementName = "ExternalReference", Namespace = Namespaces.cac)]
        public ExternalReference ExternalReference { get; set; }

        [XmlElement(ElementName = "EmbeddedDocumentBinaryObject", Namespace = Namespaces.cbc)]
        public EmbeddedDocumentBinaryObject EmbeddedDocument { get; set; }
    }



}
