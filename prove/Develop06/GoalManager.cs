using System.Runtime.CompilerServices;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    int _score;

    public GoalManager()
    {

    }

    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"you have {_score} points");
        Console.WriteLine();
    }
    
    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");
        int goalNumber = 1;
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            { Console.WriteLine($"{goalNumber}. [X] {goal.GetGoal()}"); }
            else
            { Console.WriteLine($"{goalNumber}. [ ] {goal.GetGoal()}"); }
            goalNumber++;
        }
    }

    public void CreateGoal()
    {
        
        Console.WriteLine($"what type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string userChoice = Console.ReadLine();
        if (userChoice == "1") //simple goal
        {
            Console.WriteLine("What is the name of this goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a brief description of this goal");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is the goal");
            int points =Convert.ToInt32(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);

        }

        if (userChoice == "2") // eternal goal
        {
            Console.WriteLine("What is the name of this goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a brief description of this goal");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is the goal");
            int points = Convert.ToInt32(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }

                if (userChoice == "3") //checklist goal
        {
            Console.WriteLine("What is the name of this goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a brief description of this goal");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is the goal");
            int points = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many times would you like to complete this goal?");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What should be the bonus reward?");
            int bonus = Convert.ToInt32(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("What goal would you like to record an event for?");
        ListGoalDetails();
        int userChoice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_goals[userChoice - 1]);
        _goals[userChoice-1].SetIsComplete();
        _score = _score + _goals[userChoice-1].GetPoints();
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
        
    }
}