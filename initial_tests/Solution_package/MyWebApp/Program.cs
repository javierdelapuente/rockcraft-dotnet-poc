using MyLibrary;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var greeter = new Greeter();
    return greeter.SayHello();
});

app.Run();
