using eFaktureModel.Xml.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eFaktureModel.Xml.References
{

    public class DocumentReference:IDReference
    {


        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
    }


}
