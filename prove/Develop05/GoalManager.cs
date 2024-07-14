using System;

public abstract class GoalManager
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Points { get; set; }
    protected bool IsComplete { get; set; }

    public GoalManager(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string GetDetails();
}