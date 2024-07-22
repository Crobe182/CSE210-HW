using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        User user = new User();

        while (choice != 6)
        {
            Console.WriteLine("Menu: \n1. User Stats \n2. Create new short term goal \n3. Create new long term goal \n4. Create new eternal goal \n5. Progress a goal \n6. Quit \n (enter a number)");

        choice = Console.Read();

            if (choice == 1)
            {
                user.getUserInfo();
            }

            else if (choice == 2)
            {
                Console.WriteLine("Enter Goal Name:");

                string goalName = Console.ReadLine();

                ShortTermGoal shortTermGoal = new ShortTermGoal();

                user.getGoalsInProgress().Append(shortTermGoal);
            }

            else if (choice == 3)
            {

            }

            else if (choice == 4)
            {

            }

            else if (choice == 5)
            {

            }

             else if (choice == 6)
            {

            }

            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}