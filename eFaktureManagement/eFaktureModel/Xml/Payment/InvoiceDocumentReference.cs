using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Payment
{
    public class InvoiceDocumentReference
    {
        [Required]
        [XmlElement(ElementName = "ID", Namespace = Namespaces.cbc)]
        public string ID { get; set; }

        [Required]
        [XmlElement(ElementName = "IssueDate", Namespace = Namespaces.cbc)]
        public DateTime IssueDate { get; set; }

        // Add other fields as needed from your schema
    }


}
