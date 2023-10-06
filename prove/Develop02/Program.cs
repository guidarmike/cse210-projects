using System;
using System.Collections.Generic;
using System.IO;
class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string Location { get; set; } // Creativity: property for location
    public string Affirmation { get; set; } // Creativity: property for affirmation
}

// Journal class to manage a collection of journal entries
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
class Program
{
    private static string GetLocation()
    {
        Console.WriteLine("Location (e.g., city or place):");
        return Console.ReadLine();
    }

    private static string GetAffirmation()
    {
        Console.WriteLine("Affirmation (a positive statement or thought):");
        return Console.ReadLine();
    }

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Random random = new Random();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Generate a random prompt and get user response
                    string randomPrompt = prompts[random.Next(prompts.Count)];
                    Console.WriteLine($"Random Prompt: {randomPrompt}");
                    Console.WriteLine("Response:");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    // Create a new journal entry
                    Entry entry = new Entry
                    {
                        Prompt = randomPrompt,
                        Response = response,
                        Date = date,
                        Location = GetLocation(), // Call a method to get the location
                        Affirmation = GetAffirmation() // Call a method to get the affirmation
                    };

                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added successfully.");
                    break;

                case "2":
                    // Display journal entries
                    journal.DisplayEntries();
                    break;

                case "3":
                    // Prompt user for a filename and save the journal to that file
                    Console.WriteLine("Enter the filename to save:");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file.");
                    break;

                case "4":
                    // Prompt user for a filename and load journal entries from that file
                    Console.WriteLine("Enter the filename to load:");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file.");
                    break;

                case "5":
                    // Exit the program
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}