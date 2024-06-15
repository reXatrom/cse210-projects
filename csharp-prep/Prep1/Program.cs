using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First name? ");
        string Firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string Lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {Lastname}, {Firstname} {Lastname}.");
    }
}