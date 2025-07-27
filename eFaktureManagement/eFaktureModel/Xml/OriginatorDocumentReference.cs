namespace eFaktureModel.Xml
{
    public class OriginatorDocumentReference
    {
        [System.Xml.Serialization.XmlElement("ID", Namespace = Utility.Namespaces.cbc)]
        public string ID { get; set; }  
    }
}