using System;
using System.Threading;

class BreathingActivity : MindfulnessActivity
{
    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        int timePassed = 0;
        while (timePassed < duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            timePassed += 4;

            if (timePassed >= duration) break;

            Console.Write("Now breathe out... ");
            ShowCountdown(4);
            timePassed += 4;
        }
    }
}
// This class implements a breathing activity that guides the user through a series of breathing exercises, inheriting from the MindfulnessActivity class.