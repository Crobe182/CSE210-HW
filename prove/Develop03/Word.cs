using System;
using System.Diagnostics.Metrics;

public class Word
{
    private string _inputReference;

    private string _inputScripture;

    private List<string> _Words;

    Random random = new Random();

    public Word(string reference, string scripture)
    {
        _inputReference = reference;
        _inputScripture = scripture;
    }

    public List<string> SetWords()
    {
        string[] wordsArray = _inputScripture.Split(new char[] { ' ', '.', ',', ';', '!', '?','1','2','3','4','5','6','7','8', '9' }, StringSplitOptions.RemoveEmptyEntries);

        _Words = new List<string>(wordsArray);


        return _Words;
    }

    public void FindWordsToHide()
    {
        int counter = 0;
        while (counter < 3)
        {
            int randomIndex = random.Next( _Words.Count);
            
            string hideWord = new string('-',_Words[randomIndex].Length);

            _Words[randomIndex] = hideWord;

            counter++; 
        }
    }

    public List<string> GetHiddenWords()
    {
        return _Words;
    }
}