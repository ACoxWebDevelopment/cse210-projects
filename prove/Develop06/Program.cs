using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string userChoice = "0";
        do
        {
            Console.WriteLine("Welcome to Eternal Quest Program");
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("1. Create New Goal ");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                goalManager.CreateGoal();
            }

            if (userChoice == "2")
            {
                goalManager.ListGoalDetails();
            }

            if (userChoice == "5")
            {
                goalManager.RecordEvent();
            }
        }
        while (userChoice != "6");
    }
}