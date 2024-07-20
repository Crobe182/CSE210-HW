public class Activity
{
    private string _title;

    private int _time;

    private List<string> _prompts = new();

    private string _prompt;

    private string _startMessage;

    private string _description;

    private string _endMessage;

    private bool _activityDone;

    public Activity(string title)
    {
        _title = title;
    }

    public string getTitle()
    {
        return _title;
    }

    public void setDescirption(string description)
    {
        _description = description;
    }

    public string getDescription()
    {
        return _description;
    }

    public void setTime()
    {
        Console.Write($"How long would you like to do the {getTitle()} activity? (In Seconds): ");

        string timeString = Console.ReadLine();

        _time = int.Parse(timeString);

        Console.Clear();
    }

    public int getTime()
    {
        return _time;
    }

    public void setPrompts(string listItem)
    {
        _prompts.Add(listItem);
    }

    public void setPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(0, _prompts.Count);

        _prompt = _prompts[randomIndex];
    } 

    public string getPrompt()
    {
        return _prompt;
    }   

    public void startMessage()
    {
        Console.WriteLine($"{getTitle()} Activity selected. \n\n");

        setTime();

       _startMessage = $"Welocome to the {getTitle()} Activity. \nIn this activity you will {getDescription()} \nThis Acitivy will last for {getTime()} seconds. \n\nThe activity will begin shortly.";

       Console.WriteLine(_startMessage);

       pauseAnimation();

       pauseAnimation();

       Console.Clear();
    }

    public void endMessage()
        {
            Console.WriteLine($"Well done! youe have completed the {getTime()} seconds long {getTitle()} Activity. \nYou did a great job! \nReturning to menu, please wait");

            pauseAnimation();

            Console.Clear();
        }

    public void pause(int time)
    {
        //time in milliseconds
        Thread.Sleep(time);
    }
    public void pauseAnimation()
    {
        DateTime startTime = DateTime.Now;

        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now <= endTime)
        {
             Console.Write("<");

            pause(250);

            Console.Write("\b \b");

            Console.Write("^");

            pause(250);

            Console.Write("\b \b");

            Console.Write(">");

            pause(250);

            Console.Write("\b \b");
            
            Console.Write("v");

            pause(250);

            Console.Write("\b \b");    
        } 

    }
    
}