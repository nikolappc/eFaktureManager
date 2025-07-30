namespace eFaktureModel.Xml.References
{
    public class OrderReference:IDReference
    {


        [System.Xml.Serialization.XmlElement("SalesOrderID", Namespace = Utility.Namespaces.cbc)]   
        public string SalesOrderID { get; set; }    
    }
}