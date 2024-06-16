using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guesses = 1;

        while (guesses != magicNumber)
        {
            Console.Write("Guess the magic number? ");
            string guess = Console.ReadLine();
            guesses = int.Parse(guess);

            if (guesses > magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guesses < magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}