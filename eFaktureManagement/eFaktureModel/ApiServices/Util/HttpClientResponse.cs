using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.ApiServices.Util
{
    public class HttpClientResponse<T>
    {
        public HttpClientResponse(HttpStatusCode statusCode, T? result)
        {
            StatusCode = statusCode;
            Result = result;
        }
        public HttpClientResponse(string? message, HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            Message = message;
        }
        public HttpStatusCode StatusCode { get;  set; }
        public T? Result { get;  set; }

        public string? Message { get; set; }
    }
}
