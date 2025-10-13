using eFaktureModel.ApiModels.Sale;
using eFaktureModel.Enums;
using eFaktureSync.ApiServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace eFaktureModel.ApiServices.Util
{
    public class HttpClientBuilder : HttpClientBuilder<object>
    {
        public HttpClientBuilder(IConfiguration configRoot) : base(configRoot)
        {
        }
    }
}
