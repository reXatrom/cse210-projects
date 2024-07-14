public class ChecklistGoal : GoalManager
{
    private int GoalCount { get; set; }
    private int PresentCount { get; set; }
    private int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {
        GoalCount = goalCount;
        PresentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (PresentCount < GoalCount)
        {
            PresentCount++;

            Console.WriteLine($"Recorded: {Name}. Progress: {PresentCount}/{GoalCount}. You earned {Points} points.");

            if (PresentCount == GoalCount)
            {
                IsComplete = true;
                Console.WriteLine($"Goal completed: {Name}. Bonus: {BonusPoints} points!");
            }
        }
    }

    public override string GetDetails()
    {
        return $"[Checklist Goal] {Name} - {Description} - Points: {Points} - Progress: {PresentCount}/{GoalCount} - Completed: {IsComplete} - Bonus: {BonusPoints}";
    }
}