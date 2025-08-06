using System;
using System.Collections.Generic;
using System.Threading;

class GratitudeActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "What is one thing today that made you smile?",
        "Name a person you're grateful for and why.",
        "Recall a recent challenge you're thankful you overcame.",
        "Describe something in nature you are grateful for.",
        "What is a small thing you often overlook but are thankful for?"
    };

    protected override string GetDescription()
    {
        return "This activity allows you to reflect on what you're grateful for by journaling short thoughts based on meaningful prompts.";
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        int timePassed = 0;

        while (timePassed < duration)
        {
            string prompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine($"\nPrompt: {prompt}");
            Console.Write("Write your thoughts (just a sentence or two):\n> ");

            DateTime entryStart = DateTime.Now;
            while (!Console.KeyAvailable && (DateTime.Now - entryStart).TotalSeconds < 10)
            {
                Thread.Sleep(100);
            }

            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Skipped...");
            }

            ShowSpinner(3);
            timePassed += 15; // Estimate 15 seconds per prompt
        }

        Console.WriteLine("\nThank you for journaling. Gratitude can improve mental health and overall happiness.");
    }
}
