using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.Payment
{
    public class BillingReference
    {
        [XmlElement(ElementName = "InvoiceDocumentReference", Namespace = Namespaces.cac)]
        public List<InvoiceDocumentReference> InvoiceDocumentReferences { get; set; }
    }


}
