using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly List<EventItem> events =
    [
        new EventItem
        {
            Id = 1,
            Title = "Blazor Developer Summit",
            Category = "Technology",
            Location = "Bengaluru",
            Description = "A hands-on event covering modern Blazor development and .NET.",
            Date = DateTime.Now.AddDays(10),
            Capacity = 100
        },
        new EventItem
        {
            Id = 2,
            Title = "AI & Innovation Meetup",
            Category = "AI",
            Location = "Hyderabad",
            Description = "Explore practical AI ideas, tools, and real-world applications.",
            Date = DateTime.Now.AddDays(18),
            Capacity = 75
        },
        new EventItem
        {
            Id = 3,
            Title = "Cloud Engineering Workshop",
            Category = "Cloud",
            Location = "Pune",
            Description = "Build scalable cloud-ready applications using modern development practices.",
            Date = DateTime.Now.AddDays(25),
            Capacity = 60
        }
    ];

    private readonly List<Registration> registrations = [];

    public IReadOnlyList<EventItem> GetEvents() => events;

    public EventItem? GetEvent(int id) =>
        events.FirstOrDefault(e => e.Id == id);

    public IReadOnlyList<Registration> GetRegistrations(int eventId) =>
        registrations.Where(r => r.EventId == eventId).ToList();

    public void AddRegistration(Registration registration)
    {
        registrations.Add(registration);

        var eventItem = GetEvent(registration.EventId);
        if (eventItem is not null)
        {
            eventItem.AttendanceCount++;
        }
    }
}
