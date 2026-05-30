using eFaktureModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Api.Config
{
    public class EFaktureApiOptions
    {
        public string BaseUrl { get; set; }

        public Dictionary<EApiPaths, string> Endpoints { get; set; } 
    }
}
