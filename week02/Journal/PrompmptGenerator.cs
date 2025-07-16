using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What is something you're grateful for?",
        "Describe a moment you felt peace today.",
        "What are you looking forward to tomorrow?",
        "What did you learn today?"
    };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}
// This class generates random prompts for journal entries.