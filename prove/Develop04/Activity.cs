public class Activity
{
    private string _title;

    private int _time;

    private List<string> _prompts;

    private string _prompt;

    private string _startMessage;

    private string _description;

    private string _endMessage;

    private bool _activityDone;

    public Activity(string title)
    {
        _title = title;
    }

    void enterTime()
    {
        Console.Write($"How long would you like to do the {_title} activity? (In Seconds): ");
        string timeString = Console.ReadLine();
        _time = int.Parse(timeString);
    }

    string getPrompt()
    {

        return _prompt;
    }    

    void pause()
    {
        Thread.Sleep(1000);
    }
    void pauseAnimation()
    {
        
    }


}