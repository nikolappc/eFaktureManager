using eFaktureManagement.ApiModels;
using eFaktureManagement.ApiModels.Purchase;
using eFaktureModel.Api.Models;
using eFaktureModel.ApiModels.Sale;
using eFaktureModel.ApiServices.Util;
using eFaktureModel.Enums;
using eFaktureSync.ApiServices;
using Microsoft.Extensions.Configuration;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Text.Json;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using PurchaseInvoiceDto = eFaktureModel.Api.Models.PurchaseInvoiceDto;

namespace eFaktureManagement.ApiServices
{
    public class ApiGenericInvoiceService<C, I> : IApiInvoiceService<C, I>
    {
        public Dictionary<EApiPaths, string> PathsConfirguration { get; set; }


        public readonly IConfiguration configRoot;

        public ApiGenericInvoiceService(IConfiguration configRoot, Dictionary<EApiPaths, string> pathsConfirguration)
        {

            this.configRoot = configRoot;
            PathsConfirguration = pathsConfirguration;
        }




        public async Task<List<C>?> GetChangesAsync(DateTime date)
        {
            using (var httpClient = new HttpClientBuilder<List<C>?>(configRoot))
            {
                var request = new SaleChangeRequest { date = date };

                httpClient.AddHttpContentBody(request).AddPath(PathsConfirguration[EApiPaths.CHANGES]);
                List<C>? list = await httpClient.PostResult();

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

                httpClient.AddHttpContentBody(body).AddPath(PathsConfirguration[EApiPaths.CHANGES]);

                var elem = await httpClient.PostResult();



                return elem;
            }
        }



        public async Task<I?> GetInvoiceAsync(long invoiceId)
        {
            using (var httpClient = new HttpClientBuilder<I>(configRoot))
            {

                httpClient.AddQueryItem("invoiceId", invoiceId.ToString()).AddPath(PathsConfirguration[EApiPaths.IDS]);

                var elem = await httpClient.GetResult();

                return elem;
            }
        }

        public bool GetSignature(string invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetXmlAsync(long invoiceId)
        {
            throw new NotImplementedException();
        }

        public bool VatReverseCarge(string invoiceId, double ammount)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetPdfAsync(long invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> DownloadSigned(long invoideId)
        {
            throw new NotImplementedException();
        }
    }
}
