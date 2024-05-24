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

    public void LoadEntries(string loadFromFile)
    {
        

        string[] previousEntries = System.IO.File.ReadAllLines(loadFromFile);

        foreach (string line in previousEntries)
        {
            string[] parts = line.Split("==================================================");

            _previousEntries = previousEntries;      
        }
    }

    public void DisplayJournalMenuOptions()
    {
        {
            bool run = true;

            Entry newEntry = new Entry();

            while (run == true)
            {

                Console.Write("What would you like to do? \n1.Write \n2.Display \n3.Load \n4.Save\n 5.Quit\n");

                string choice = Console.ReadLine();
                    
                if (choice == "1")
                {
                    newEntry.GetEntry();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("What file would you like to load from? ");

                    string loadFromFile = Console.ReadLine();
                    LoadEntries(loadFromFile);
                    DisplayEntries(_previousEntries);
                }
                else if (choice == "3")
                {
                        
                }
                else if (choice == "4")
                {
                    newEntry.SaveEntry();
                }
                else if (choice == "5")
                {
                    run = false;   
                }
                else
                {
                    Console.WriteLine("Invalid input: ");
                }
            }
        }
    }
}

