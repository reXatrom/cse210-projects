using System;
using System.Collections.Generic;

class Program
{
    private static List<GoalManager> goals = new List<GoalManager>();
    private static int totalPoints = 0;
    
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program!");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    RecordEvent();
                    break;

                case "3":
                    ShowGoals();
                    break;

                case "4":
                    ShowScore();
                    break;

                case "5":
                    SaveGoals();
                    break;

                case "6":
                    LoadGoals();
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid Option, Please Try Again.");
                    break;

            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist");
        var type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        var name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        var description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        var points = int.Parse(Console.ReadLine());

        GoalManager goal = null;

        switch (type)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;

            case "2":
                goal = new EternalGoal(name, description, points);

            case "3":
                Console.Write("Enter target count: ");
                var goalCount = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                var bonusPoints = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, goalCount, bonusPoints);
                break;
            
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goals.Add(goal);
        Console.WriteLine("Goal created successfully.")
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Choose a goal to record event:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
        }

        var choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= goals.Count)
        {
            goals[choice - 1].RecordEvent();
            totalPoints += goals[choice - 1].Points;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    private static void ShowGoals()
    {
        Console.WriteLine("Goals:");

        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    private static void ShowScore()
    {
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    private static void SaveGoals()
    {
    }

    private static void LoadGoals()
    {
    }

}