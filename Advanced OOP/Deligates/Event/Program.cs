using System;
namespace Event;

public class Program
{
    public static void Main(string[] args)
    {
        Events event1 = new Events("Quiz");
        Events event2 = new Events("Debugging");
        Events event3 = new Events("Presentation");
        Events event4 = new Events("Games");

        // Event registration by managemnet
        // Subscribe to events
        Events.eventlink += new EventManager(event1.ShowEvent);
        Events.eventlink += new EventManager(event2.ShowEvent);
        Events.eventlink += new EventManager(event3.ShowEvent);
        Events.eventlink += new EventManager(event4.ShowEvent);

        Events.HandleEvent();  // Indirectly using a method

        // Unsubscribe from event
        Events.eventlink -= new EventManager(event4.ShowEvent);

        Events.HandleEvent();
    }
}
