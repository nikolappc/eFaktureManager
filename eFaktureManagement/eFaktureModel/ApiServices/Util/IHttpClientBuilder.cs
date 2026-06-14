using eFaktureModel.ApiModels.Sale;
using eFaktureSync.ApiServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public interface IHttpClientBuilder<T>
    {

        IHttpClientBuilder<T> AddQueryItem(string name, string item);
        IHttpClientBuilder<T> AddPath(string path);
        IHttpClientBuilder<T> AddHeader(string name, string value);
        IHttpClientBuilder<T> AddHttpContentUbl(byte[] data);
        IHttpClientBuilder<T> AddHttpContentText(string data, Encoding encoding);

        IHttpClientBuilder<T> AddQueryParams(Dictionary<string, string?> keyValues);
        IHttpClientBuilder<T> AddHttpContentBody(object requestBody);
        Task<HttpClientResponse<T?>> GetResult();
        Task<HttpClientResponse<T?>> PostResult();
        Task<HttpClientResponse<T?>> DeleteResult();

        IHttpClientBuilder<T> AddPathParam(long invoiceId);
    }
}
