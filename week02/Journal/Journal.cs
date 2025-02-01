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
                    writer.WriteLine(entry);
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
            try
            {
                _entries.Clear();
    
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    string prompt = null;
                    string response = null;
                    DateTime date = DateTime.MinValue;
    
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("Date: "))
                        {
                            date = DateTime.Parse(line.Substring(6));
                        }
                        else if (line.StartsWith("Prompt: "))
                        {
                            prompt = line.Substring(8);
                        }
                        else if (line.StartsWith("Response: "))
                        {
                            response = line.Substring(10);
                        }
                        else if (line == "")
                        {
                            if (prompt != null && response != null)
                            {
                                _entries.Add(new Entry(prompt, response) { Date = date });
                                prompt = null;
                                response = null;
                            }
                        }
                    }
    
                    
                    if (prompt != null && response != null)
                    {
                        _entries.Add(new Entry(prompt, response) { Date = date });
                    }
                }
    
                Console.WriteLine("Journal loaded successfully.\n");
    
               
                DisplayEntries();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal: {ex.Message}\n");
            }
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
    }

}