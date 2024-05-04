using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter numbers to add to the list.\n Enter the number 0 to finish\n");

        List<int> numbers = new();

        int appened = 1;

        while (appened != 0)
        {
            Console.Write("Enter a number: ");
            string entered = Console.ReadLine();

            appened = int.Parse(entered);

            if (appened != 0 )
                {
                numbers.Add(appened);
                }
        }

        int sum = 0;

        int average = 0;

        int listLen = 0;

        int largest = 0;

        foreach (int number in numbers)
        {
            sum += number;
            average += number;
            listLen += 1;
            if (number > largest)
            {
                largest = number;
            }
        }

        average = average / listLen;

        Console.WriteLine($"The sum is {sum}");

        Console.WriteLine($"The average is {average}");

        Console.WriteLine($"The largest number is {largest}");

    }
}