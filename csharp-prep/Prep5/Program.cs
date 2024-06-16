using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string UserName = Console.ReadLine();

        return UserName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int UserNumber = int.Parse(Console.ReadLine());

        return UserNumber;
    }

    static int SquareNumber(int UserNumber)
    {
        int SqrNumber = UserNumber * UserNumber;

        return SqrNumber;
    }

    static void DisplayResult(string UserName, int SqrNumber)
    {
        Console.WriteLine($"{UserName}, the square of your number is {SqrNumber}.");
    }
}