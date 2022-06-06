using Microsoft.AspNetCore.Builder;

namespace ChuckSwapiC.Web.Middleware
{
    public static class Configuration
    {
        public static IApplicationBuilder ResultObjectExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResultObjectExceptionMiddleware>();
        }
    }
}