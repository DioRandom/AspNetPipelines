using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;

namespace AspNetPipelines.Api.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseRefererMiddleware(this IApplicationBuilder builder)
        {
            return builder.Use(async (context, next) =>
            {
                if (context.Request.Headers["Referer"].ToString() != "https://some-cool-app.com")
                {
                    await next(); 
                }
                else
                {
                    

                    context.Response.StatusCode = 403;
                    await context.Response.WriteAsync("Access Denied");
                }
            });
        }
    }
}
