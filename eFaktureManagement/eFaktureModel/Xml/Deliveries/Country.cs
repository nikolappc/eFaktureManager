using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Deliveries
{

    public class Country
    {
        [XmlElement(ElementName = "IdentificationCode", Namespace = Namespaces.cbc)]
        public string IdentificationCode { get; set; }
    }


}
