using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindfulness program.");
        Console.WriteLine("1 ... Breathing Activity");
        Console.WriteLine("2 ... Listing Activity");
        Console.WriteLine("3 ... Reflecting Activity");
        Console.WriteLine("4 ... Quit");

         string userChoice;
        userChoice = Console.ReadLine();

        while (userChoice != "4")
        {
            if (userChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run("breathing");
            }

            if (userChoice == "2")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run("Listing");
            }
            if (userChoice == "3")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run("Reflecting");
            }

                    Console.WriteLine("Welcome to the mindfulness program.");
        Console.WriteLine("1 ... Breathing Activity");
        Console.WriteLine("2 ... Listing Activity");
        Console.WriteLine("3 ... Reflecting Activity");
        Console.WriteLine("4 ... Quit");

        userChoice = Console.ReadLine();
            

        }
    }
}