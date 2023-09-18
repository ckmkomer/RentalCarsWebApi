using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Serilog;
using System.Diagnostics;
using System.Net;
using Formatting = Newtonsoft.Json.Formatting;

namespace RentalCars.Application.Middleware
{
    public class SerilogExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public SerilogExceptionMiddleware(RequestDelegate next)
        {
            _next = next;

            _logger = new LoggerConfiguration()
                
                .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}")
                .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day)
                 .MinimumLevel.Information()

                .CreateLogger();
        }

        public async Task Invoke(HttpContext context)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                string message = "[Request] HTTP " + context.Request.Method + " " + context.Request.Path;
                _logger.Information(message);
                await _next(context);

                watch.Stop();

                message = "[Request] HTTP " + context.Request.Method + " " + context.Request.Path + " Responded " + context.Response.StatusCode + " in " + watch.Elapsed.TotalMilliseconds + " ms";
                _logger.Information(message);
            }
            catch (Exception ex)
            {
                watch.Stop();
                await HandleException(context, ex, watch);
            }
        }

        private Task HandleException(HttpContext context, Exception ex, Stopwatch watch)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

          
            var customErrorMessage = "İşlem sırasında bir hata oluştu. Lütfen hata mesajını gözden geçiriniz.";

            string message = "[Error] HTTP " + context.Request.Method + " - " + context.Response.StatusCode + " Error Message " + customErrorMessage + " in " + watch.Elapsed.TotalMilliseconds + " ms";
            _logger.Error(ex, message);

            var result = JsonConvert.SerializeObject(new { error = customErrorMessage }, Formatting.None);
            return context.Response.WriteAsync(result);
        }
    }

    public static class CustomExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomExceptionMiddle(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SerilogExceptionMiddleware>();
        }
    }
}
