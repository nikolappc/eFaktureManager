namespace eFaktureModel.Xml.References
{
    public class OrderReference
    {

        [System.Xml.Serialization.XmlElement("ID", Namespace = Utility.Namespaces.cbc)]
        public string ID { get; set; }

        [System.Xml.Serialization.XmlElement("SalesOrderID", Namespace = Utility.Namespaces.cbc)]   
        public string SalesOrderID { get; set; }    
    }
}