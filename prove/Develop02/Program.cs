using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.IO;

class Program
{
    
     
         
    
    static void Main(string[] args)
    {
        

        

        Journal myJournal = new Journal();
        Entry journalEntry = new Entry();

        
        //Console.WriteLine("Hello Develop02 World!");
        string menu="";
        while (menu !="q")
        {
            Console.WriteLine ("Welcome to the journaling program");
            Console.WriteLine ("What would you like to do?  Please choose one of the following");
            Console.WriteLine ("1. Write");
            Console.WriteLine ("2. Display");
            Console.WriteLine ("3. Load");
            Console.WriteLine ("4. Save");
            Console.WriteLine ("q for quit");
            menu = Console.ReadLine();

            if (menu == "1")
            {
                
                myJournal.AddEntry(journalEntry);
                Console.WriteLine($"{myJournal._entries}");
                
            }
            else if (menu == "2")
            {
                myJournal.DisplayEntry(journalEntry);
                Console.WriteLine("Press enter to continue");
                Console.Read();
            }

            else if (menu == "3")
            {
                string myFile= "my1stjournal.txt";
                myJournal.LoadFromFile(myFile);
            }

            else if (menu == "4")
            {
                myJournal.SaveToFile(journalEntry);
            }
        }                
             
    }
}