using Microsoft.AspNetCore.Diagnostics;
using IT_Asset_Management.Exceptions;

namespace IT_Asset_Management.Middlewares
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            switch (exception)
            {
                case NotFoundException notFoundException:
                    httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                    await httpContext.Response.WriteAsJsonAsync(new { Message = notFoundException.Message }, cancellationToken);
                    break;
                case AlreadyTakenException alreadyTakenException:
                    httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                    await httpContext.Response.WriteAsJsonAsync(new { Message = alreadyTakenException.Message }, cancellationToken);
                    break;
                default:
                    httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    await httpContext.Response.WriteAsJsonAsync(new { Message = "Внутрішня помилка сервера" }, cancellationToken);
                    break;
            }

            return true;
        }
    }
}
