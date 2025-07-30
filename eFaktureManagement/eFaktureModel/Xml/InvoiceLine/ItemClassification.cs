using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.InvoiceLine
{
    public class ItemClassification
    {
        [XmlElement(ElementName = "ItemClassificationCode", Namespace = Namespaces.cbc)]
        public string ItemClassificationCode { get; set; }

        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }

        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
    }



}
