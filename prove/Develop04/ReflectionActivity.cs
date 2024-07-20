using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

public class ReflectionActivity : Activity
{
    List<string> _questions = new();

    string _question;
    
    public ReflectionActivity(): base("Reflection")
    {
        setDescirption("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recongocnize the power you have, and how you can use it in other aspects of your life.");

        setPrompts("Think of a time when you overcame a difficult challenge.");
        //_questions.Append("Think of a time when you overcame a difficult challenge.");
        setPrompts("Think of a time when you helped someone in need.");
        //_questions.Append("Think of a time when you helped someone in need.");
        setPrompts("Think of a time when you felt the spirit in your life.");
       // _questions.Append("Think of a time when you felt the spirit in your life.");
        setPrompts("Think of a time when you accomplished a goal you had set for yourself.");
        //_questions.Append("Think of a time when you accomplished a goal you had set for yourself.");

        setQuestions();
    }

    void setQuestions()
    {
        _questions.Add("How did you feel when this experience was complete? ");

        _questions.Add("What was your favorite thing about this experience? ");

        _questions.Add("What was something you learned as a result of this experience?");

        _questions.Add("In what ways will this experience help you in the future? ");
    }

    public string getQuestion()
    {
        Random random = new Random();

        int randomIndex = random.Next(0, _questions.Count);

        _question = _questions[randomIndex]; 

        return _question;
    }

    public void reflectionLoop()
    {
        Console.WriteLine("Consider the following prompt:\n");

        setPrompt();

        Console.WriteLine(getPrompt());
        
        pauseAnimation();

        Console.WriteLine("When You have something in mind press any key to continue.");

        Console.ReadKey();
        
        DateTime startTime = DateTime.Now;

        DateTime endTime = startTime.AddSeconds(getTime());

        while (DateTime.Now <= endTime)
        {
            Console.Clear();

            Console.WriteLine(getQuestion());

            pauseAnimation();

            pauseAnimation();
        }
    }
}