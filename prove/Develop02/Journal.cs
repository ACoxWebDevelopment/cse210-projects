using System;  
using System.Collections.Generic;  
using System.IO; 

public class Journal
{
    public List<Entry> _entries;

    //public Journal()
    //{
    //    _entries = new List<Entry>();
    //}

    public void AddEntry(Entry myEntry)
    {
        PromptGenerator myPromptGenerator = new PromptGenerator();
        List<string> myString = new List<string>();
        myString.Add("What is the best thing that happened today");
        myString.Add("If I had one thing I could do over today, what would it be?");
        myString.Add("Is there anything about today I would like to remember 1 year from now?");
        myString.Add("Did I do something to make someone's day better?");
        myString.Add ("What am I looking forward to tomorrow?");
        
        Console.Write("Enter today's date: ");
        myEntry._date = Console.ReadLine();
        myEntry._promptText = myPromptGenerator.GeneratePrompt(myString);
        Console.WriteLine(myEntry._promptText);
        myEntry._entryText = Console.ReadLine();
        Console.WriteLine(myEntry);
        
    }

    // Displays the provided entry
    public void DisplayEntry(Entry myEntry)
    {
        Console.WriteLine(myEntry._date);
        Console.WriteLine(myEntry._promptText);
        Console.WriteLine(myEntry._entryText);
    }

    // Saves an entry to a file
    public void SaveToFile(Entry myEntry)
    {
        string myFile = @"C:\Users\allan\Programming_with_classes\cse210-projects\prove\Develop02\my1stjournal.txt";

        using (StreamWriter saveFile = File.AppendText(myFile))
        {
            saveFile.WriteLine($"{myEntry._date} {myEntry._promptText} {myEntry._entryText}");
        }
    }

    // Loads an entry from a file
    public void LoadFromFile(string myEntry)
    {
        string myFile = @"C:\Users\allan\Programming_with_classes\cse210-projects\prove\Develop02\my1stjournal.txt";
        string[] lines = System.IO.File.ReadAllLines(myFile);
        Console.WriteLine($"{lines[2]}");
        Console.WriteLine("Press enter to continue");
        Console.Read();
    }
}
