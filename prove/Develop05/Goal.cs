using System.ComponentModel;

abstract public class Goal
{
    private int _completionPointValue;

    private int _portionPointValue;

    private int _partsUntilComplete;

    private string _title;

    private string _goalType;

    private string _goalTitleAndDescription;

    public Goal(string goalType, string goalName)
    {
        _goalType = goalType;

        _title = goalName;
    }

    public int getCompletePointValue()
    {
        return _completionPointValue;
    }

    abstract public void setCompletionpointValue();

    public string getGoalDescription()
    {
        Console.WriteLine("Enter goal desription/plan: ");
        string description = Console.ReadLine();
        return description;
    }

    public void setGoalTitleAndDescription()
    {
        string description = getGoalDescription();
        _goalTitleAndDescription = $"{_title}: {description}";
    }
    


}