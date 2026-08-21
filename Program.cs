using EventHub.Services;

var builder = WebApplication.CreateBuilder(args);

// Services.
builder.Services.AddSingleton<IEventService, EventService>();
builder.Services.AddControllers();

var app = builder.Build();  // App Initializer.

// Logging middleware.
app.Use(async (context, next) =>
{
    Console.WriteLine($"Incoming request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response sent: {context.Response.StatusCode}");
});

app.MapControllers();

app.Run();