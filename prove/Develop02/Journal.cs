using System;
using System.Collections.Generic;
using System.IO;
class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Location: {entry.Location}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine($"Affirmation: {entry.Affirmation}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"Response: {entry.Response}");
                writer.WriteLine();
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))

        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                Entry entry = null;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.StartsWith("Date: "))
                    {
                        entry = new Entry();
                        entry.Date = line.Substring("Date: ".Length);
                    }
                    else if (line.StartsWith("Prompt: "))
                    {
                        entry.Prompt = line.Substring("Prompt: ".Length);
                    }
                    else if (line.StartsWith("Response: "))
                    {
                        entry.Response = line.Substring("Response: ".Length);
                        entries.Add(entry);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}