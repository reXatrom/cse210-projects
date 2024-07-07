using System;
using System.Threading;

abstract class Activity
{
    protected int TimeFrame { get; private set; }

    public Activity(int timeFrame)
    {
        TimeFrame = timeFrame;
    }

    public void Run()
    {
        DisplayStartMessage();
        PerformActivity();
        DisplayEndMessage();
    }

    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {GetType().Name}....");
        Console.WriteLine(GetDescription());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed the {GetType().Name} for {TimeFrame} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }

    protected abstract string GetDescription();
    protected abstract void PerformActivity();

}