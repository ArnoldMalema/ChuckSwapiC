using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace ChuckSwapiC.Application.Utilities.Http
{
     public class HttpAdapter : IHttpAdapter
    {

        private static readonly HttpClient Client = new HttpClient(new HttpClientHandler()
        {
            UseDefaultCredentials = true,
        });


        public TResult Get<TResult>(string url, bool isLoggable, List<HttpHeaderDto> headers = null, bool allowFailedResult = false)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                if (headers != null)
                {
                    foreach (var header in headers)
                        request.Headers.Add(header.Name, header.Value);
                }

                using (var response = Client.SendAsync(request).Result)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    if (!response.IsSuccessStatusCode && !allowFailedResult)
                        throw new Exception($"URL: {url}. {response.StatusCode}: {jsonString}");
                    
                    return (TResult) JsonConvert.DeserializeObject(jsonString, typeof(TResult));

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
