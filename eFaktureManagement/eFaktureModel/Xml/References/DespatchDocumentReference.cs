namespace eFaktureModel.Xml.References
{
    public class DespatchDocumentReference
    {
        [System.Xml.Serialization.XmlElement("ID", Namespace = Utility.Namespaces.cbc)]
        public string ID { get; set; }  
    }
}