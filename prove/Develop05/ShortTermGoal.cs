using System;

public class ShortTermGoal : Goal 
{
    public ShortTermGoal() :base("ShortTermGoal", "goalName")
    {

    }

    public override void setCompletionpointValue()
    {
         _completionPointValue = 100;
    }

    
}