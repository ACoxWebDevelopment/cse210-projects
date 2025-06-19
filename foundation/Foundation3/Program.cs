using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(3,6,10, 30);
        ExerciseBicycle exerciseBicycle = new ExerciseBicycle(15, 10, 6);
        LapSwimming lapSwimming = new LapSwimming(10,2,5);
        Console.WriteLine(running.GetSummary());
        
        Console.WriteLine("Hello Foundation3 World!");
    }
}