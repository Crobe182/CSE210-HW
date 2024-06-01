using System;

public class Scripture
{
    private List<string> allHidden;

    private List<string> currentlyHidden;

    private string _inputReference;
    private string _inputScripture;

    private bool _finished = false;

    public Scripture(string reference, string scripture)
    {
        _inputReference = reference;
        _inputScripture = scripture;
    }

    public void ClearConsole()
    {
        Console.Clear();
    }

    public List<string> CreateAllHidden()
    {
        string[] wordsArray = _inputScripture.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> beforeAllHidden = new List<string>(wordsArray);

        for (int i = 0; i < beforeAllHidden.Count; i++)
        {
            string hideWord = new string('-',beforeAllHidden[i].Length);

                beforeAllHidden[i] = hideWord;

        }

        allHidden = beforeAllHidden;

        return allHidden;
    }

    public void GetCurrentlyHidden(List<string>_words)
    {
        currentlyHidden = _words;
    }

    public bool CheckForDone()
    {
        if (allHidden.SequenceEqual(currentlyHidden))
        {
            _finished = true;
        }

        return _finished;
    }

    public bool getfinished()
    {
        return _finished;
    }

    public void PrintNewConsole()
    {
        Console.WriteLine(_inputReference);

        for (int i = 0; i < currentlyHidden.Count; i++)
        {
            Console.Write($"{currentlyHidden[i]} ");
        } 
    }
}