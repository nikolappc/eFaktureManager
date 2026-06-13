using eFaktureModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Api.Config
{
    public class GenericEFaktureApiOptions<E>
    {
        public GenericEFaktureApiOptions()
        {
            Endpoints = new Dictionary<E, string>();    
        }

        public string? BaseUrl { get; set; } = null;

        public Dictionary<E, string> Endpoints { get; set; } = new();
    }
}
