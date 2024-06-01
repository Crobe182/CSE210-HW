using System;

class Program
{
    static void Main(string[] args)
    {
        Reference theReference = new Reference();

        theReference.SetReferenceAndScripture();

        string reference = theReference.GetSelectedKey();

        string scripture = theReference.GetSelectedScript();

        Console.WriteLine(reference);

        Console.WriteLine(scripture);

        Word word = new Word(reference, scripture);

        word.SetWords();

        Scripture theScripture = new Scripture(reference, scripture);

        theScripture.GetCurrentlyHidden(word.GetHiddenWords());

        theScripture.CreateAllHidden();

        while (theScripture.getfinished() == false)
        {
            Console.WriteLine("\nType 'quit' to quit or hit the 'enter key' to continue: ");

            string keepgoing = Console.ReadLine();

            if (keepgoing == "quit")
            {
                Console.WriteLine("Program has been stopped.");
                break;
            } 
            
            else if (keepgoing == "")
            {
                theScripture.CheckForDone();
                word.FindWordsToHide();
                theScripture.ClearConsole();
                theScripture.PrintNewConsole();
                Console.WriteLine();
            }
        }
        Console.WriteLine("\n\nProgram finished\n\n");




    }
}