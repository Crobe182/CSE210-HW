using System;
using System.Reflection.Metadata;
using System.IO;

public class Entry
{
    public string _prompt = ("");
    public string _entry = ("");
    public string _date = ("");

    

    public Entry()
    {
        
    }

    public void GetPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();

        int randomIndex = random.Next(0, prompts.Count);

       _prompt = prompts[randomIndex];
    }

    public void GetEntry()
    {
        GetPrompt();

        GetDate();

        Console.WriteLine($"{_prompt}");

        Console.Write("> ");

        string newEntry = Console.ReadLine();

        _entry = newEntry;
    }

    public void GetDate()
    {
        DateTime date = DateTime.Now;

        _date = date.ToShortDateString();
    }

    public void SaveEntry()
    {
        Console.WriteLine("Where would you like to save to? (i.e. Journal.txt) ");

        string savetoFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(savetoFile))

        outputFile.WriteLine($"--------------------------------------------------\n{_date}\n{_prompt}\n\n{_entry}\n==================================================");
    }

    
}