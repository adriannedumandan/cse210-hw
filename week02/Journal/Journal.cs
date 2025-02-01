using System;
using System.Collections.Generic;
using System.IO;

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

    public void SaveToFile()
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.Date.ToString("yyyy-MM-dd HH:mm:ss")); 
                    writer.WriteLine(entry.Prompt);
                    writer.WriteLine(entry.Response);
                    writer.WriteLine("---"); 
                }
            }
            Console.WriteLine("Journal saved successfully.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}\n");
        }
    }   


    public void LoadFromFile()
        {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _entries.Clear(); 

            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Trim() == "---") continue; 

                if (i + 2 < lines.Length)
                {
                    string dateStr = lines[i].Trim();
                    string prompt = lines[i + 1].Trim();
                    string response = lines[i + 2].Trim();

                    if (DateTime.TryParse(dateStr, out DateTime date))
                    {
                        Entry entry = new Entry(prompt, response) { Date = date };
                        _entries.Add(entry);
                    }
                    i += 2; 
                }
            }

            if (_entries.Count > 0)
            {
                Console.WriteLine("\nJournal successfully loaded.\n");
                DisplayEntries(); 
            }
            else
            {
                Console.WriteLine("File is empty or incorrectly formatted.\n");
            }
        }
        else
        {
            Console.WriteLine("Error: File does not exist.\n");
        }
    }

}