using EventHub.Models;
using EventHub.Services;

var builder = WebApplication.CreateBuilder(args);

// Services.
builder.Services.AddSingleton<EventService>();

var app = builder.Build();  // App Initializer.

// Logging middleware
app.Use(async (context, next) =>
{
    Console.WriteLine($"Incoming request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response sent: {context.Response.StatusCode}");
});

// Routes (DI).
app.MapGet("/events", (EventService eventService) => eventService.GetAllEvents());

// app.UseHttpsRedirection();
app.Run();