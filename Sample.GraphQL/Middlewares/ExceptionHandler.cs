using HotChocolate.Resolvers;

namespace Sample.GraphQL.Middlewares;

public class ExceptionHandler
{
    private readonly FieldDelegate _next;

    public ExceptionHandler(FieldDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(IMiddlewareContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    
}
