using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.";
    }

    protected override void PerformActivity()
    {
        int cycleTime = 6;
        int cycles = _duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountdown(3);
            Console.WriteLine();
        }
    }
}
