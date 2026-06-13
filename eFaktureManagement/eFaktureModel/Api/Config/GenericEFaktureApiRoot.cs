using eFaktureModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Api.Config
{
    public class GenericEFaktureApiRoot<S, E>
    {

        public GenericEFaktureApiRoot()
        {
            ApiPaths = new Dictionary<S, GenericEFaktureApiOptions<E>>();
        }
        public Dictionary<S, GenericEFaktureApiOptions<E>> ApiPaths { get; set; }
    }
}
