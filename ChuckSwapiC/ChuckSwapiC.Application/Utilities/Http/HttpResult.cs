using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ChuckSwapiC.Application.Utilities.Http
{
    public class HttpResult<TResult>
    {
        private readonly TResult body;
        private readonly HttpStatusCode statusCode;

        public HttpResult(TResult body, HttpStatusCode statusCode)
        {
            this.body = body;
            this.statusCode = statusCode;
        }

        public TResult Body => body;

        public HttpStatusCode StatusCode => statusCode;
    }
}
