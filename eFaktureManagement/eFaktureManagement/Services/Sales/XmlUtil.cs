using eFaktureModel.Xml.Utility;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using eFaktureModel.Xml;
using System.Xml.Schema;

namespace eFaktureManagement.Services.Sales
{
    public static class XmlUtil
    {
        public static string GetXsdPath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(basePath, "XmlFiles", "ubl2.1.xsd");

            if (!File.Exists(relativePath))
            {
                throw new FileNotFoundException($"XSD file not found at path: {relativePath}");
            }
            return relativePath;    
        }
        public static void ValidateXml(string xmlContent, string xsdPath)
        {
            var settings = new XmlReaderSettings();
            settings.Schemas.Add(null, xsdPath);
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationEventHandler += (sender, e) =>
            {
                throw new XmlSchemaValidationException($"Validation error: {e.Message}");
            };

            using var reader = XmlReader.Create(new StringReader(xmlContent), settings);
            while (reader.Read()) { }
        }


        public static string SerializeInvoice(Invoice invoice)
        {
            var serializer = new XmlSerializer(typeof(Invoice));
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("cbc", Namespaces.cbc);
            namespaces.Add("cac", Namespaces.cac);
            namespaces.Add("", Namespaces.Invoice);

            var settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                OmitXmlDeclaration = false
            };

            using var stringWriter = new StringWriter();
            using var xmlWriter = XmlWriter.Create(stringWriter, settings);
            serializer.Serialize(xmlWriter, invoice, namespaces);
            return stringWriter.ToString();
        }


    }
}
