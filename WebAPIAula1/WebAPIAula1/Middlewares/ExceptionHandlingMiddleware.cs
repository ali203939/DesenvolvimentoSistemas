using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Text.Json;
using WebAPIAula1.Domain.Exceptions;

namespace WebAPIAula1.Middlewares;

/// <summary>
/// Global exception handling middleware
/// </summary>
public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        _logger.LogError(exception, "An unhandled exception occurred");

        var response = context.Response;
        response.ContentType = "application/json";

        var errorResponse = new
        {
            message = exception.Message,
            statusCode = (int)HttpStatusCode.InternalServerError
        };

        switch (exception)
        {
            case DomainException:
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                errorResponse = new
                {
                    message = exception.Message,
                    statusCode = (int)HttpStatusCode.BadRequest
                };
                break;

            case ArgumentException:
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                errorResponse = new
                {
                    message = exception.Message,
                    statusCode = (int)HttpStatusCode.BadRequest
                };
                break;

            default:
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                errorResponse = new
                {
                    message = "An internal server error occurred",
                    statusCode = (int)HttpStatusCode.InternalServerError
                };
                break;
        }

        var result = JsonSerializer.Serialize(errorResponse);
        await response.WriteAsync(result);
    }
}
