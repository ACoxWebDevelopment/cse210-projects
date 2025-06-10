using System.Diagnostics;
using System.Runtime.CompilerServices;

class Activity
{
    private string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage(string description)
    {
        _description = description;
        Console.Write($"Welcome to the {_description} activity.  ");
    }

    public void DisplayEndingMessage(string description, int duration)
    {
        _description = description;
        _duration = duration;
        Console.WriteLine($"You participated in the {_description} activity for {_duration} seconds");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinBars = new List<string> { "|", "/", "-", "\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {

            {
                string s = spinBars[i];
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
                i++;
            }

            if (i >= spinBars.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountdown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }
}