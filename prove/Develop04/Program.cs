using System;

class Program
{
    static void Main()
    {
        bool _quit = false;

        Console.Clear();

        while (_quit == false)
        {
            Console.WriteLine("Menu options:");

            Console.WriteLine("1. Start Breating activity \n2. Start Reflecting activity \n3. Start Listing activity \n4. Quit");

            Console.Write("Select a choice from the menu: ");

            string _choice =Console.ReadLine();

            Console.Clear();

            if (_choice == "1")
            {
                BreathingActivity Breathing = new BreathingActivity();

                Breathing.startMessage();

                Breathing.breathingLoop();

                Breathing.endMessage();
            }

            else if (_choice == "2")
            {
                ReflectionActivity Reflection = new ReflectionActivity();

                Reflection.startMessage();

                Reflection.reflectionLoop();
                
                Reflection.endMessage();
            }

            else if (_choice == "3")
            {
                ListingActivity Listing = new ListingActivity();

                Listing.startMessage();

                Listing.listingLoop();

                Listing.endMessage();
            }

            else if (_choice =="4")
            {
                _quit = true; 
            }
            
        }
    }
}