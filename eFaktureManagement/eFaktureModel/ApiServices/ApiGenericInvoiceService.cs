using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureModel.Api.Config;
using eFaktureModel.ApiModels.Sale;
using eFaktureModel.ApiServices;
using eFaktureModel.ApiServices.Util;
using eFaktureModel.Enums;
using eFaktureSync.ApiServices;
using Microsoft.Extensions.Configuration;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Text.Json;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using PurchaseInvoiceDto = eFaktureModel.Api.Models.Purchase.PurchaseInvoiceDto;

namespace eFaktureManagement.ApiServices
{
    public abstract class ApiGenericInvoiceService<C, I> : IApiInvoiceService<C, I>
    {
        public GenericEFaktureApiOptions<EApiPaths> PathsConfiguration { get; set; }

        public readonly IConfiguration configRoot;

        public ApiGenericInvoiceService(IConfiguration configRoot, EFaktureApiRoot pathsConfigRoot)
        {
            this.configRoot = configRoot;

            this.PathsConfiguration = ExtractPathOptions(pathsConfigRoot);
        }


        protected abstract EApiSections GetSection();
        private GenericEFaktureApiOptions<EApiPaths> ExtractPathOptions(EFaktureApiRoot pathsConfiguration)
        {
            var section = GetSection();
            if (pathsConfiguration.ApiPaths.ContainsKey(section))
            {
                return pathsConfiguration.ApiPaths[section];
            }
            return new();
        }

        public async Task<List<C>?> GetChangesAsync(DateTime date)
        {
            var path = PathsConfiguration.Endpoints[EApiPaths.CHANGES];
            var root = PathsConfiguration.BaseUrl;
            var apiKey = configRoot.GetSection("API_KEY")?.Value??null;
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new Exception("Api key not provided.");
            }
            if (string.IsNullOrWhiteSpace(root))
            {
                throw new Exception("Api root not found.");
            }
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new Exception("Api path not found.");
            }


            using (var httpClient = new HttpClientBuilder<List<C>?>(root))
            {
                var request = new SaleChangeRequest { date = date };
            
                httpClient.AddHttpContentBody(request).AddHeader("apikey", apiKey).AddPath(path);
                List<C>? list = (await httpClient.PostResult()).Result;

                return list ?? new();
            }
        }


        public async Task<List<long>?> GetIdsAsync(string status, DateTime from, DateTime to)
        {
            using (var httpClient = new HttpClientBuilder<List<long>?>(configRoot))
            {

                var body = new
                {

                    status,
                    from,
                    to
                };

                httpClient.AddHttpContentBody(body).AddPath(PathsConfiguration.Endpoints[EApiPaths.IDS]);

                var elem = await httpClient.PostResult();



                return elem.Result;
            }
        }



        public async Task<I?> GetInvoiceAsync(long invoiceId)
        {
            using (var httpClient = new HttpClientBuilder<I>(configRoot))
            {

                httpClient.AddQueryItem("invoiceId", invoiceId.ToString()).AddPath(PathsConfiguration.Endpoints[EApiPaths.IDS]);

                var elem = await httpClient.GetResult();

                return elem.Result;
            }
        }

        public async Task<byte[]> DownloadSigned(long invoiceId)
        {
            return await GetFileAsync(invoiceId, PathsConfiguration.Endpoints[EApiPaths.IDS]);
        }

        public async Task<byte[]> GetXmlAsync(long invoiceId)
        {
            return await GetFileAsync(invoiceId, PathsConfiguration.Endpoints[EApiPaths.XML_DOWNLOAD]);
      
        }

        public async Task<byte[]> GetPdfAsync(long invoiceId)
        {

            return await GetFileAsync(invoiceId, PathsConfiguration.Endpoints[EApiPaths.PDF_DOWNLOAD]);  
        
        }

        private async Task<byte[]> GetFileAsync(long invoiceId, string path)
        {
            using (var httpClient = new HttpClientBuilder<Stream>(configRoot))
            {

                httpClient.AddQueryItem("invoiceId", invoiceId.ToString()).AddPath(path);

                using (var stream = await httpClient.GetStream())
                {
                    using (var ms = new MemoryStream())
                    {
                        await stream.CopyToAsync(ms);
                        return ms.ToArray();
                    }
                }
            }
        }

    }
}
