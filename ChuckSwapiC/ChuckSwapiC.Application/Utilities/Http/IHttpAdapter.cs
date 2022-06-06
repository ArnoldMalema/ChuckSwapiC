using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckSwapiC.Application.Utilities.Http
{
    public interface IHttpAdapter
    {
        TResult Get<TResult>(string url, bool isLoggable, List<HttpHeaderDto> headers = null,
            bool allowFailedResult = false);
    }
}
