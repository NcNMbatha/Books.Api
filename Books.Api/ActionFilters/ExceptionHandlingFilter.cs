using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace Books.Api.ActionFilters
{
    public class ExceptionHandlingFilter: ExceptionFilterAttribute
    {
        private readonly ILogger<ExceptionHandlingFilter> _logger;

        public ExceptionHandlingFilter(ILogger<ExceptionHandlingFilter> logger)
        {
            _logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, context.Exception.Message);

            var statusCode = HttpStatusCode.InternalServerError;
            var message = "An unexpected error occurred. Please try again later.";

            if (context.Exception is ArgumentException)
            {
                statusCode = HttpStatusCode.BadRequest;
                message = "Invalid argument provided.";
            }
            else if (context.Exception is NotFoundException)
            {
                statusCode = HttpStatusCode.NotFound;
                message = "The requested resource was not found.";
            }

            context.Result = new JsonResult(new
            {
                error = message,
                details = context.Exception.Message
            })
            {
                StatusCode = (int)statusCode
            };

            base.OnException(context);
        }

        public class NotFoundException : Exception
        {
            public NotFoundException(string message) : base(message) { }
        }
    }
}
