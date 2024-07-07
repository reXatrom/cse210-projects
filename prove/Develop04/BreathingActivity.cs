using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(int timeFrame) : base(timeFrame) { }

    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        for (int i = 0; i < TimeFrame; i += 6)
        {
            Console.WriteLine("Breath in...");
            ShowCountdown(3);

            Console.WriteLine("Breath out...");
            ShowCountdown(3);
        }
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write($"{seconds - i} ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }
}