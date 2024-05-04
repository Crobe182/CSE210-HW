using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A random number has been chosen! \n");

        Random randomGenerator = new Random();

        int randomNumber = randomGenerator.Next(1, 101);

        int guessedNumber = (0);

        while (guessedNumber != randomNumber)
        {
            Console.Write("What is your guess? ");

            string guess = Console.ReadLine();

            guessedNumber = int.Parse(guess);

            if (guessedNumber > randomNumber)
            {
            Console.Write("lower \n");
            }
            if (guessedNumber < randomNumber) 
            {
            Console.Write("higher \n");
            }
            if (guessedNumber == randomNumber)
            {
            Console.Write("Congrats! you guessed the magic number! \n");
            }
        }
    }
}