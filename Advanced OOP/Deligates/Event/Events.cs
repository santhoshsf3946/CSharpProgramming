using System;

namespace Event
{
    public delegate void EventManager();  // User Defined deligate

    public class Events
    {
        private string _eventName;

        public static event EventManager eventlink = null;  // User Defined Event

        static int i;

        public Events(string eventName)
        {
            _eventName = eventName;
        }

        // public static void EventStarter()  
        // {
        //     i = 0;
        //     Console.WriteLine("\nUser Registration");
        //     HandleEvent();  // Calling event triggering method
        // }

        public static void HandleEvent()  // Event triggering method
        {
            i = 0;
            Console.WriteLine("\nUser Registration");
            Console.WriteLine("\nStarting the following events");
            eventlink();  // Event Trigger -> Like clicking a button
        }

        public void ShowEvent()  // Explanation about the button click option
        {
            ++i;
            Console.WriteLine($"\nEvent No: {i} is: {_eventName} started");
        }
    }
}
