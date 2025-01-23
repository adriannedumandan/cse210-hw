using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private readonly List<string> _prompts = new List<string>
    {
        "What am I grateful for today?",
        "What was the strongest emotion I felt today?",
        "What did I learn today?",
        "Who made me smile earlier?",
        "How did I see the hand of the Lord in my life today?"

    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        string response = Console.ReadLine();

        _entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry added successfully.\n");
    }

    public void DisplayEntries()
    {
        if(_entries.Count == 0)
        {
            Console.WriteLine("No entries.\n");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
}