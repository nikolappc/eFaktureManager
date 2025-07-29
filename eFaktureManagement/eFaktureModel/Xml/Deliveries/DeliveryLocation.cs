using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Deliveries
{
    public class DeliveryLocation:ID
    {
        [XmlElement(ElementName = "Address", Namespace = Namespaces.cac)]
        public Address Address { get; set; }
    }


}
