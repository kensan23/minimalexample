var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<FooService>();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGet("/someotherfoo", ([FromServices]FooService foo) => foo.GetFoo);
app.AddFooEndpoint();
app.Run();
