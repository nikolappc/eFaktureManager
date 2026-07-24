using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace CommonLib
{
    public abstract class ApiKeyAuthenticationHandler : AuthenticationHandler<ApiKeyOptions>
    {
        private const string API_KEY_HEADER_NAME = "X-API-Key";

        private readonly IConfiguration _configuration;

        public ApiKeyAuthenticationHandler(
            IOptionsMonitor<ApiKeyOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IConfiguration configuration)
            : base(options, logger, encoder, clock)
        {
            _configuration = configuration;
        }
        protected abstract string GetAPIKeyName();

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (Context.Request.Method == "OPTIONS")
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            if (!Context.Request.Headers.TryGetValue(API_KEY_HEADER_NAME, out var apiKeyHeader))
            {
                return Task.FromResult(AuthenticateResult.Fail("API Key missing"));
            }

            var apiKey = _configuration[GetAPIKeyName()];
            var requestApiKey = apiKeyHeader;

            if (!SecureCompare(apiKey, requestApiKey))
            {
                return Task.FromResult(AuthenticateResult.Fail("Invalid API Key"));
            }

            var identity = new ClaimsIdentity(new[] { new Claim("ApiKey", "valid-key") }, Options.Scheme);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Options.Scheme);

            return Task.FromResult(AuthenticateResult.Success(ticket));
        }


        private static bool SecureCompare(string? a, string? b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                return false;

            if (a.Length != b.Length)
                return false;

            var result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }
            return result == 0;
        }
    }
}
