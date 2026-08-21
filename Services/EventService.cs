using EventHub.Models;

namespace EventHub.Services;

public class EventService
{
    private readonly List<Event> _events =
    [
        new(1, "Tech Meetup", "Guadalajara", new DateTime(2026, 8, 18)),
        new(2, "Hackaton", "Mexico City", new DateTime(2026, 8, 24)),
        new(3, "Team Building", "Monterrey", new DateTime(2026, 8, 26)),
    ];

    public List<Event> GetAllEvents()
    {
        return _events;
    }
}