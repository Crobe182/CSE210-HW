public class ListingActivity : Activity
{
    List<string> _items = new();

    string _item;

    public ListingActivity() : base("Listing")
    {
        setDescirption("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        setPrompts("When have you flet the Holy Ghost this month?");

        setPrompts("When did you feel happy this week?");

        setPrompts("Who are some new people you have met this week?");

        setPrompts("What made you smile or laugh today?");
    }

    public void listingLoop()
    {
        Console.WriteLine("List as many items as you can to the following prompt:\n");

        setPrompt();

        Console.WriteLine(getPrompt());

        Console.WriteLine("You may begin shortly.");
        
        pauseAnimation();

        DateTime startTime = DateTime.Now;

        DateTime endTime = startTime.AddSeconds(getTime());

        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");

            _item = Console.ReadLine();

            _items.Add(_item);
        }

        Console.WriteLine($"You listed {_items.Count} items!\n"); 

        pauseAnimation();


    }
}