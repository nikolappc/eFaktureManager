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
    public class HttpClientBuilder<T> : IDisposable
    {
        private readonly IConfiguration configRoot;
        public HttpClient httpClient { get; private set; }
        private UriBuilder _uriBuilder;

        private NameValueCollection _queryParams;
        private bool _disposedValue;
        private HttpContent _httpContent;

        public HttpClientBuilder(IConfiguration configRoot)
        {
            this.configRoot = configRoot;
            this._uriBuilder = new UriBuilder(configRoot[ApiConstants.API_ROOT]);   
            _queryParams = new NameValueCollection();
            httpClient = new HttpClient();  

        }

        public HttpClientBuilder<T> AddQueryItem(string name, string item)
        {
            _queryParams[name] = item;

            return this;
        }
        public HttpClientBuilder<T> AddPath(string path)
        {
            _uriBuilder.Path = path;

            
            return this;  
        }
        public HttpClientBuilder<T> AddHttpContentUbl(byte[] data)
        {
            var fileContent = new ByteArrayContent(data);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/xml");

            var multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Add(fileContent, "ubl", "invoice.xml");

            _httpContent = multipartFormDataContent;    

            return this;
        }


        public HttpClientBuilder<T> AddQueryParams(Dictionary<string, string?> keyValues)
        {
            keyValues.ToList().ForEach(kv => _queryParams[kv.Key] = kv.Value);

            return this;    
        }

        public HttpClientBuilder<T> AddHttpContentBody(object requestBody)
        {
            var requestData = JsonSerializer.Serialize(requestBody);
            _httpContent = new StringContent(requestData, System.Text.Encoding.UTF8, MediaTypeNames.Application.FormUrlEncoded);

            return this;
        }

        public async Task<T> GetResult()
        {
            var response = await httpClient.GetAsync(_uriBuilder.ToString());
       
            T result = await GetHttpResult(response); 

            return result;  
        }

        private async Task<T> GetHttpResult(HttpResponseMessage response)
        {
            var responseBody = await response.Content.ReadAsStringAsync();

            T? resultingInvoice =
             JsonSerializer.Deserialize<T?>(responseBody);


            return resultingInvoice;
        }

        public async Task<T?> PostResult()
        {
            var response = await httpClient.PostAsync(_uriBuilder.ToString(), _httpContent);

            T result = await GetHttpResult(response);

            return result;
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
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
    }
}
