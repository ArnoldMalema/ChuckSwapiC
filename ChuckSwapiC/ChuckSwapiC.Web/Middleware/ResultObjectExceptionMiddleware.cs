using System;
using System.Text.Json;
using System.Threading.Tasks;
using ChuckSwapiC.Application.Utilities.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ChuckSwapiC.Web.Middleware
{
    public class ResultObjectExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger logger;
    
        public ResultObjectExceptionMiddleware(RequestDelegate next, ILogger<ResultObjectExceptionMiddleware> logger)
        {
            _next = next;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch(Exception ex)
            {
                logger.LogError(ex, context.Request.Path);
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";
                var errorChain = ex.GetExceptionMessageChain();
                var json = JsonSerializer.Serialize(string.Join(", " ,errorChain.ToArray()));
                await context.Response.WriteAsync(json);
            }
        }

    }
}