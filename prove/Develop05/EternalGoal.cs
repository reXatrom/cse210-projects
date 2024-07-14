public class EternalGoal : GoalManager
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal Recorded: {Name}. You earned {Points} points.");
    }

    public override string GetDetails()
    {
        return $"[Eternal Goal] {Name} - {Description} - Points: {Points} - Always Ongoing.";
    }
}