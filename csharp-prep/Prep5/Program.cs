using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int inputnum)
    {
        return inputnum * inputnum;
    }

    static void Main()
    {
        DisplayWelcome();
        string alias = PromptUserName();
        int favnum = PromptUserNumber();
        int numsquared = SquareNumber(favnum);
        Console.WriteLine($"{alias}, your number squared is {numsquared}");
    }
}