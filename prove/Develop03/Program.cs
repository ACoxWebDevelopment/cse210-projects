using System;

class Program
{
    static void Main(string[] args)
    {
        Reference singleVerse = new Reference("John", 3, 16);
        Reference multiVerse = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture1 = new Scripture(singleVerse, "For God so loved the world that He gave His only Begotten Son");
        Scripture scripture2 = new Scripture(multiVerse, "Trust in the Lord with all your heart and lean not unto your own understanding");

        Console.Clear();
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("type quit and then enter to quit or just enter to hide a word");
        string input = "";
    while (input == "" && !scripture1.IsCompletelyHidden())
        {
            Console.WriteLine();
             input = Console.ReadLine();


            if (input == "quit")
            {
                break;
            }
            scripture1.HideRandomWords();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(scripture1.GetDisplayText());
        }       
    }
}