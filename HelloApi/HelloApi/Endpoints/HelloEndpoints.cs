namespace HelloApi.Endpoints;

public static class HelloEndpoints
{
    public static WebApplication AddHelloEndpoints(this WebApplication app)
    {
        var endpoint = app.MapGroup("/api");

        endpoint.MapGet("/sayHello", () => Results.Ok("Hello!"));

        return app;
    }
}
