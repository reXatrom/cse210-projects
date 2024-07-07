using System;
using System.Threading;

class ListingActivity : Activity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int timeFrame) : base(timeFrame) { }

    protected override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        int promptIndex = random.Next(Prompts.Length);
        Console.WriteLine(Prompts[promptIndex]);
        ShowSpinner(3);

        Console.WriteLine("Start listing...");
        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(TimeFrame);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} items.");
    }
}
