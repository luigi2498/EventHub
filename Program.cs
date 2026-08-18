var builder = WebApplication.CreateBuilder(args);

var events = new List<Event>
{
    new Event(1, "Tech Meetup", "Guadalajara", new DateTime(2026, 8, 18)),
    new Event(2, "Hackaton", "Mexico City", new DateTime(2026, 8, 24)),
    new Event(3, "Team Building", "Monterrey", new DateTime(2026, 8, 26)),
};

var app = builder.Build();

// Routes.
app.MapGet("/events", () => events);

app.UseHttpsRedirection();
app.Run();

record Event(int Id, string Name, string Location, DateTime Date);