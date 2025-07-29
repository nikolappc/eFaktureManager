using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Deliveries
{
    public class Delivery
    {
        [XmlElement(ElementName = "DeliveryParty", Namespace = Namespaces.cac)]
        public DeliveryParty DeliveryParty { get; set; }

        [XmlElement(ElementName = "DeliveryLocation", Namespace = Namespaces.cac)]
        public DeliveryLocation DeliveryLocation { get; set; }

        [XmlElement(ElementName = "ActualDeliveryDate", Namespace = Namespaces.cbc)]
        public DateTime? ActualDeliveryDate { get; set; }
    }



}
