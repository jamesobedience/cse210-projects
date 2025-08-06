using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    protected override string GetDescription()
    {
        return "This activity will help you reflect on times when you have shown strength and resilience. Recognize the power you have and how you can use it in life.";
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        ShowSpinner(5);

        int timePassed = 0;
        while (timePassed < duration)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
            timePassed += 5;
        }
    }
}
// This class implements a reflection activity that prompts the user to think about their experiences and reflect on them, inheriting from the MindfulnessActivity class.