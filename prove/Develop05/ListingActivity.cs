using System.Configuration.Assemblies;

class ListingActivity :Activity
{
    private List<string> _prompts = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"  };
    private List<string> _userResponses = new List<string>();
    public void Run(string description)
    {
        _description = description;
        DisplayStartingMessage(_description);
        Console.WriteLine("This activity will challenge you to list as many things as you can in a given amount of time");
        Console.WriteLine("How much time(in seconds) would you like? ");
        _duration = Convert.ToInt32(Console.ReadLine());

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        GetRandomPrompt();
        while (DateTime.Now < endTime)
        {
            //Console.WriteLine(DateTime.Now - endTime);
            GetListFromUser();
        }
        Console.WriteLine($"You entered {_userResponses.Count} items");
        DisplayEndingMessage(_description, _duration);

    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int userPrompt = random.Next(0, _prompts.Count);

        Console.WriteLine(_prompts[userPrompt]);
    }
    public List<string> GetListFromUser()
    {
        _userResponses.Add(Console.ReadLine());
        return _userResponses;
    }
}
