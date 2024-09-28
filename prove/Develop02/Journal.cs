
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    
    private List<Entry> _entries = new List<Entry>();

    
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

   
    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.FormatForSave());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            foreach (var line in File.ReadAllLines(filename))
            {
                _entries.Add(Entry.FromFormattedString(line));
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
