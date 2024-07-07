using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            Console.Write("Enter the time frame in seconds: ");
            int timeFrame = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity(timeFrame);
                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity(timeFrame);
                    reflection.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity(timeFrame);
                    listing.Run();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please, try again");
                    break;
            }
        } 
    }
}