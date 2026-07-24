using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib
{
    public class ApiKeyOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScheme = "ApiKey";
        public string Scheme => DefaultScheme;
        public string AuthenticationType = DefaultScheme;

        public string HeaderName { get; set; } = "X-API-Key";
    }
}
