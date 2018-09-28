using Microsoft.AspNetCore.Builder;

namespace Hummer.Fly.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestIP(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestIPMiddleware>();
        }
    }
}
