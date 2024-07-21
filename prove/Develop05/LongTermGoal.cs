using System;

public class LongTermGoal : Goal 
{
    public LongTermGoal() :base("LongTermGoal")
    {

    }

    public override void setCompletionpointValue()
    {
        _completionPointValue = 300;
    }

    public override void setPartPointValue()
    {
        _partPointValue = 50;
    }

    public override void setPartsUntilComplete()
    {
        Console.Write("Number of parts until complete: ");

        _partsUntilComplete = Console.Read();
    }


}