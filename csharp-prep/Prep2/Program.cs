using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int gradeNumber = int.Parse(gradePercent);

        string letterGrade = ("");

        if (gradeNumber >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeNumber >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeNumber >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeNumber >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next time.");
        }
    }
}