using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml
{
    public class InvoicePeriod
    {
        [XmlElement("DescriptionCode", Namespace = Namespaces.cbc)]
        public string DescriptionCode { get; set; }



        [XmlElement(ElementName = "StartDate", Namespace = "cbc-namespace")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [XmlElement(ElementName = "EndDate", Namespace = "cbc-namespace")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

    }

}
