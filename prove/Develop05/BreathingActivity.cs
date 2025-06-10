class BreathingActivity :Activity
{




    public void Run(string description)
    {
        _description = description;

        DisplayStartingMessage(_description);
        Console.WriteLine("This activity will help you be mindful of your breathing");
        Console.WriteLine("Enter in seconds the amount of time you would like to do this activity");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Write("Beginning in: "); ShowCountdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {

            {
                Console.Clear();
                Console.WriteLine("Breathe in");
                ShowCountdown(3);
                Console.WriteLine("Breathe Out");
                ShowCountdown(3);
            }

        }
        DisplayEndingMessage(_description, _duration);
        ShowSpinner(5);
    }
}