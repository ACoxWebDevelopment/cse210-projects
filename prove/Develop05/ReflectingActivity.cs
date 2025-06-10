using System.ComponentModel;

class ReflectingActivity :Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>(){"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    public void Run(string description)
    {
        _description = description;
        DisplayStartingMessage(_description);
        Console.WriteLine("This activity will help you think deeper about your experiences");
        Console.WriteLine("How much time (in seconds) would you like to spend on this activity?");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Think about an experience that was meaningful to you:  Press enter when ready");
        Console.ReadLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {

            GetRandomPrompt();
            DisplayPrompt();
            ShowSpinner(5);
            Console.ReadLine();
        }
        DisplayEndingMessage(_description, _duration);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int userPromptNumber = random.Next(0, _questions.Count);
        return _questions[userPromptNumber];
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {
        string chosenPrompt = GetRandomPrompt();
        Console.WriteLine(chosenPrompt);
    }

    public void DisplayQuestions()
    {
        
    }
}