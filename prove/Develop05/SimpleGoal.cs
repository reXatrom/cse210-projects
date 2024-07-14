public class SimpleGoal : GoalManager
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        IsComplete = true;
        Console.WriteLine($"Goal completed: {Name}. You earned {Points} points.");
    }

    public override string GetDetails()
    {
        return $"[Simple Goal] {Name} - {Description} - {Points} - Completed: {IsCompleted}";
    }
}