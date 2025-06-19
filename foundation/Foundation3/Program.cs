using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(3, 30);
        ExerciseBicycle exerciseBicycle = new ExerciseBicycle(15, 30);
        LapSwimming lapSwimming = new LapSwimming(10, 30);
        Console.WriteLine(running.GetSummary());

        Console.WriteLine("Hello Foundation3 World!");
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(exerciseBicycle);
        activities.Add(lapSwimming);
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}