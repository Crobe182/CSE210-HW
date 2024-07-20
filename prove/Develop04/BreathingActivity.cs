using System.Reflection;

public class BreathingActivity : Activity
{

    public BreathingActivity() :base("Breathing")
    {
        setDescirption("This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breating.");
    }

    public void breathingLoop()
    {
        DateTime startTime = DateTime.Now;

        DateTime endTime = startTime.AddSeconds(getTime());

        while (DateTime.Now <= endTime)
        {
            Console.WriteLine($"Breathe in..."); 

            pauseAnimation();

            Console.WriteLine($"Breathe out...");

            pauseAnimation();

            Console.WriteLine("");
        }

        Console.Clear();
    }
    

}