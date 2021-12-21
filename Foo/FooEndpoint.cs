namespace Foo;

public static class FooEndpoint
{
    public static IEndpointRouteBuilder AddFooEndpoint(this IEndpointRouteBuilder endpoint)
    {
        endpoint.MapGet("/foo", ([FromServices] FooService _foo) => _foo.GetFoo());
        return endpoint;
    }
}

