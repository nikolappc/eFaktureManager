using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.References
{
    public class EmbeddedDocumentBinaryObject
    {
        [XmlText]
        public byte[] Value { get; set; }

        [XmlAttribute(AttributeName = "mimeCode")]
        [Required]
        public string MimeCode { get; set; }

        [XmlAttribute(AttributeName = "filename")]
        [Required]
        public string Filename { get; set; }
    }


}
