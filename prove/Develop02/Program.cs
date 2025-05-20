using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.IO;
using System.Xml.Serialization;

class Program
{




    static void Main(string[] args)
    

    {
        
        string choice = "";
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        while (choice != "5")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {

                string aprompt = promptGenerator.GeneratePrompt();
                Console.WriteLine($"{aprompt}");
                string promptResponse = Console.ReadLine();


                Entry myEntry = new Entry();
                
                myEntry._date = DateTime.Now.ToShortDateString();
                myEntry._promptText = aprompt;
                myEntry._entryText = promptResponse;
                
                myEntry.DisplayEntry();
                myJournal.AddEntry(myEntry);
            }
            if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            if (choice == "3")
            {
                Console.WriteLine("Please Enter a filename");
                string fylename = Console.ReadLine();
                myJournal.LoadFromFile(fylename);
            }
            if (choice == "4")
                {
                    Console.WriteLine("Please Enter a filename: ");
                    string fylename = Console.ReadLine();
                    myJournal.SaveToFile(fylename);
                }
        }
        Console.WriteLine("Thank-You for using the Journal Program.");
    }
}