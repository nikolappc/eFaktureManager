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
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace eFaktureModel.ApiServices.Util
{
    public class HttpClientBuilder<T> : IDisposable, IHttpClientBuilder<T>
    {
        private readonly IConfiguration? configRoot;
        private HttpClient _httpClient;
        private UriBuilder? _uriBuilder;

        private NameValueCollection? _queryParams;
        private bool _disposedValue;
        private HttpContent? _httpContent;

        public HttpClientBuilder(IConfiguration configRoot)
        {
            this.configRoot = configRoot;
            this._uriBuilder = new UriBuilder(configRoot[EApiPaths.API_ROOT.ToString()] ?? "");
            _queryParams = new NameValueCollection();
            _httpClient = new HttpClient();
        }
        public HttpClientBuilder(string root)
        {
            this._uriBuilder = new UriBuilder(root ?? "");
            _queryParams = new NameValueCollection();
            _httpClient = new HttpClient();

        }

        public IHttpClientBuilder<T> AddQueryItem(string name, string item)
        {
            _queryParams[name] = item;

            return this;
        }
        public IHttpClientBuilder<T> AddPath(string path)
        {
            _uriBuilder.Path = path;


            return this;
        }
        public IHttpClientBuilder<T> AddHttpContentUbl(byte[] data)
        {
            var fileContent = new ByteArrayContent(data);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/xml");

            var multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Add(fileContent, "ubl", "invoice.xml");

            _httpContent = multipartFormDataContent;

            return this;
        }


        public IHttpClientBuilder<T> AddQueryParams(Dictionary<string, string?> keyValues)
        {
            keyValues.ToList().ForEach(kv => _queryParams[kv.Key] = kv.Value);

            return this;
        }

        public IHttpClientBuilder<T> AddHttpContentBody(object requestBody)
        {
            _httpContent = JsonContent.Create(requestBody);

            return this;
        }

        public async Task<HttpClientResponse<T>> GetResult()
        {
            var response = await _httpClient.GetAsync(_uriBuilder.ToString());

            var result = await GetHttpResult(response);

            return result;
        }
        public async Task<Stream> GetStream()
        {
            var response = await _httpClient.GetAsync(_uriBuilder.ToString());

            var stream = await response.Content.ReadAsStreamAsync();

            return stream;
        }

        private async Task<HttpClientResponse<T?>> GetHttpResult(HttpResponseMessage response)
        {



            var responseBody = await response.Content.ReadAsStringAsync();
            switch (response.StatusCode)
            {

                case System.Net.HttpStatusCode.OK:


                    T? resultingInvoice =
                     JsonSerializer.Deserialize<T?>(responseBody);

                    var result = new HttpClientResponse<T?>(response.StatusCode, resultingInvoice);

                    return result;

                case System.Net.HttpStatusCode.NoContent:

                case System.Net.HttpStatusCode.NotModified:
                case System.Net.HttpStatusCode.NotFound:
                case System.Net.HttpStatusCode.TooManyRequests:
                case System.Net.HttpStatusCode.InternalServerError:
                default:
                    return new HttpClientResponse<T?>(responseBody, response.StatusCode);


            }

        }
        public async Task<HttpClientResponse<T?>> DeleteResult()
        {
            var response = await _httpClient.DeleteAsync(_uriBuilder.ToString());

            var result = await GetHttpResult(response);

            return result;
        }
        public async Task<HttpClientResponse<T?>> PostResult()
        {
            var response = await _httpClient.PostAsync(_uriBuilder.ToString(), _httpContent);

            var result = await GetHttpResult(response);

            return result;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    _httpClient.Dispose();

                    this._httpContent = null;
                    this._queryParams = null;
                    this._uriBuilder = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~HttpClientCreator()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public IHttpClientBuilder<T> AddHttpContentText(string data, Encoding encoding)
        {
            var stringContent = new StringContent(data, encoding, "application/xml");

            _httpContent = stringContent;

            return this;
        }

        public IHttpClientBuilder<T> AddPathParam(long invoiceId)
        {
            _uriBuilder.Path = Path.Combine(_uriBuilder.Path, invoiceId.ToString());

            return this;
        }
    }
}
