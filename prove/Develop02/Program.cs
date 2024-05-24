using System;

public class Program
{
    static void Main(string[] args)
    {
            Journal journal = new Journal();


            journal.DisplayJournalMenuOptions();
    }

     public void DisplayMenu()
    {
       
        {
            bool run = true;

            while (run == true)

            Console.Write("What would you like to do? \n1.Write \n2.Display \n3.Load \n4.Save\n 5.Quit\n");

            string choice = Console.ReadLine();
                
            if (choice == "1")
            {
                Entry newEntry = new Entry();
                newEntry.GetEntry();
            }
            else if (choice == "2")
            {
                Console.WriteLine("What file would you like to load from? ");

                string loadFromFile = Console.ReadLine();
             //   journal.LoadEntries(loadFromFile);
             //   Journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                    
            }
            else if (choice == "4")
            {
                    
            }
            else if (choice == "5")
            {
                run = false;   
            }
            else
            {
                Console.WriteLine("Invalid input: ");
                DisplayMenu();
            }
        }
    }
}