using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates one of each of the activities
        Activity running = new Running("13 Aug 2023", 35, 6.0);

        Activity cycling = new Cycling("25 Sept 2023", 40, 18.0);

        Activity swimming = new Swimming("1 Oct 2023", 25, 42);

        // Adds the activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Displays summaries for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());

            Console.WriteLine();
        }
    }
}