using eFaktureModel.Xml.InvoiceLine;
using eFaktureModel.Xml.References;
using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.InvoiceLines
{
    public class Item
    {
        [XmlElement("Name", Namespace = Namespaces.cbc)]
        public string Name { get; set; }

        [XmlElement(ElementName = "Description", Namespace = Namespaces.cbc)]
        public string Description { get; set; }


        [XmlElement("SellersItemIdentification", Namespace = Namespaces.cac)]
        public SellersItemIdentification SellersItemIdentification { get; set; }
        [XmlElement(ElementName = "BuyersItemIdentification", Namespace = Namespaces.cac)]
        public IDReference BuyersItemIdentification { get; set; }

        [XmlElement(ElementName = "StandardItemIdentification", Namespace = Namespaces.cac)]
        public SchemeReference StandardItemIdentification { get; set; }

        [XmlElement(ElementName = "CommodityClassification", Namespace = Namespaces.cac)]
        public List<ItemClassification> CommodityClassifications { get; set; }

        [XmlElement(ElementName = "OriginCountry", Namespace = Namespaces.cac)]
        public Country OriginCountry { get; set; }

        [XmlElement(ElementName = "AdditionalItemProperty", Namespace = Namespaces.cac)]
        public List<ItemProperty> AdditionalItemProperties { get; set; }



        [XmlElement("ClassifiedTaxCategory", Namespace = Namespaces.cac)]
        public ClassifiedTaxCategory ClassifiedTaxCategory { get; set; }
    }


}
