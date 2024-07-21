using System.ComponentModel;
using System.Dynamic;
using System;

abstract public class Goal
{
    protected int _completionPointValue;

    protected int _partPointValue;

    protected int _partsUntilComplete;

    private string _title;

    private string _description;

    private string _experience;

    private string _goalType;

    private string _goalTitleAndDescription;

    private bool _complete;

    public Goal(string goalType)
    {
        Console.WriteLine("Enter Goal Name:");

        string goalName = Console.ReadLine();

        _goalType = goalType;

        _title = goalName;

        _complete = false;
    }

    public int getCompletePointValue()
    {
        return _completionPointValue;
    }

    virtual public void setPartPointValue()
    {
        _partPointValue = 0;
    }

    virtual public void setPartsUntilComplete()
    {
        _partsUntilComplete = 0;
    }

    abstract public void setCompletionpointValue();

    public void setGoalDescription()
    {
        Console.WriteLine("Enter goal desription/plan: ");
        _description = Console.ReadLine();
        
    }

    public string getGoalDescription()
    {
        return _description;
    }

    public string getGoalTitle()
    {
        return _title;
    }

    public void setGoalTitleAndDescription()
    {
        string description = getGoalDescription();

        _goalTitleAndDescription = $"{_title}: {description}";
    }

    public string getGoalTitleAndDescription()
    {
        return _goalTitleAndDescription;
    }

    public void setExperience()
    {
        Console.WriteLine("Record your thoughts, feelings, and things you learned:");

        _experience = Console.ReadLine();
    }

    public string getExperience()
    {
        return _experience;
    }
    
    public void setComplete()
    {
        _complete = true;
    }

    public bool getComplete()
    {
        return _complete;
    }

}