using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates three addresses for the three events
        Address address1 = new Address("2489 Mercedes Cr", "Springfield", "IL", "USA");
        
        Address address2 = new Address("7915 Oak St", "Toronto", "ON", "Canada");

        Address address3 = new Address("3294 Tsuzuki St", "Naoshi Prefecture", "Tokyo", "Japan");

        // Creates the three events
        Event lecture = new Lecture("Game Dev Basics", "An introductory lecture on Game Development", "2024-09-11", "10:00 AM", address1, "Mark Fishbach", 50);

        Event reception = new Reception("Wedding", "The reception of Mr. and Mrs. Westbrook", "2024-10-15", "6:00 PM", address2, "rsvp@someemail.com");

        Event outdoorGathering = new OutdoorGathering("Summer Grill Party", "A fun get together in the park", "2024-08-22", "12:00 PM", address3, "Sunny and warm");

        // Creates a list of the events
        Event[] events = [lecture, reception, outdoorGathering];

        // Displays the details for each event
        foreach (Event eventItem in events)
        {
            Console.WriteLine("Standard Details:");

            Console.WriteLine(eventItem.GetStandardDetails());

            Console.WriteLine();

            Console.WriteLine("Full Details:");

            Console.WriteLine(eventItem.GetFullDetails());

            Console.WriteLine();

            Console.WriteLine("Short Description:");

            Console.WriteLine(eventItem.GetShortDescription());

            Console.WriteLine();
        }
    }
}