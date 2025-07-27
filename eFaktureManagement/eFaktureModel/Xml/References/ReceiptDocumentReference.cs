namespace eFaktureModel.Xml.References
{
    public class ReceiptDocumentReference
    {

        [System.Xml.Serialization.XmlElement("ID", Namespace = Utility.Namespaces.cbc)] 
        public string ID { get; set; }  
    }
}