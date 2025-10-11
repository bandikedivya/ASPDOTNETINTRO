using Introduction.Middleware;

namespace Introduction.Extensions
{
    public static class MiddlewareExtensions
    {

        public static IApplicationBuilder UseHttpContextDemo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HTTPContextMiddleware>();
        }

        public static IApplicationBuilder UseLoggingContextDemo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }



        //public static IApplicationBuilder UseHttpContextDemo(this IApplicationBuilder builder)
        //{
        //    return builder.UseMiddleware<HTTPContextMiddleware>();
        //}

        public static IApplicationBuilder UseAuthenticationDemo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddleware>();
        }


        public static IApplicationBuilder UseJWTAuthenticationDemo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<JWTAuthenticationMiddleware>();
        }
    }
}