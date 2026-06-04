using eFaktureModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Api.Config
{
    public class EFaktureApiRoot
    {

        public EFaktureApiRoot()
        {
                ApiPaths = new Dictionary<EApiSections, EFaktureApiOptions>();
        }
        public Dictionary<EApiSections, EFaktureApiOptions> ApiPaths { get; set; } 
    }
}
