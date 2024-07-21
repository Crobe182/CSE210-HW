using System;

public class EternalGoal : Goal 
{
    public EternalGoal() :base("EternalGoal")
    {

    }

    public override void setCompletionpointValue()
    {
        _completionPointValue = 50;
    }

    
}