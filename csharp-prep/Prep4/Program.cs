using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userDigit = -1;
        while (userDigit != 0)
        {
            Console.Write("Enter a number (hit 0 to cancel): ");

            string userResponse = Console.ReadLine();
            userDigit = int.Parse(userResponse);
            
            if (userDigit != 0)
            {
                numbers.Add(userDigit);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
    
}