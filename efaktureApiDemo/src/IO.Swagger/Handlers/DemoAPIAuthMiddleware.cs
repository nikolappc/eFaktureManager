using CommonLib;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;

namespace eFaktureApiDemo.Middleware
{
    public class DemoAPIAuthHandler : ApiKeyAuthenticationHandler
    {
        public DemoAPIAuthHandler(IOptionsMonitor<ApiKeyOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IConfiguration configuration) : base(options, logger, encoder, clock, configuration)
        {
        }

        protected override string GetAPIKeyName()
        {
            return "MAIN_API_KEY";
        }
    }
}
