using System;


public class Journal
{
    public string[] _previousEntries = new string[1];

    public void DisplayEntries(string[] _previousEntries)
    {
        foreach (string line in _previousEntries)
        {
            Console.WriteLine(line);
        }
    }

    public void LoadEntries(string[] loadFromFile)
    {
        

        string[] previousEntries = System.IO.File.ReadAllLines(loadFromFile);

        foreach (string line in previousEntries)
        {
            string[] parts = line.Split("==================================================");

            _previousEntries = previousEntries;      
        }
    }
}

