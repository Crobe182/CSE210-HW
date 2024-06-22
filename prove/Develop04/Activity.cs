class Activity
{
    string _title;

    int time;

    List<string> prompts;

    string prompt;

    bool activityDone;

    public Activity(string title)
    {
        _title = title;
    }

    void enterTime()
    {
        Console.Write($"How long would you like to do the {_title} activity? (In Seconds): ");
        string timeString = Console.ReadLine();
        time = int.Parse(timeString);
    }

    string getPrompt()
    {

        return prompt;
    }    

    void pauseAnimation()
    {
        
    }


}