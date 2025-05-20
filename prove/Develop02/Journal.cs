using System;  
using System.Collections.Generic;  
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll() //display all journal entries
    {
        foreach (Entry i in _entries)
        {
            i.DisplayEntry();
        }
    }

    public void SaveToFile(string fylename)
    {

        using (StreamWriter writer = new StreamWriter(fylename))
        {
            foreach (Entry i in _entries)
            {
                writer.WriteLine($"{i._date} , {i._promptText}, {i._entryText}");
            }
            Console.WriteLine($"{fylename} saved");
        }    
    }

    public void LoadFromFile(string fylename)
    {
        string[] lines = System.IO.File.ReadAllLines(fylename);
        foreach (string i in lines)
        {
            string[] parts = i.Split(",");
            string _date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];

            Entry myEntry = new Entry();
            myEntry._date = _date;
            myEntry._promptText = promptText;
            myEntry._entryText = entryText;

            _entries.Add(myEntry);


        }
         Console.WriteLine($"File {fylename} loaded");

        
    }
}
