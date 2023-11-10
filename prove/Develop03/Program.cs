using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the book:");
        string book = Console.ReadLine();

        Console.WriteLine("Enter the chapter:");
        int chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the starting verse:");
        int verseStart = int.Parse(Console.ReadLine());

        Console.WriteLine("Does this reference have an ending verse? (Y/N)");
        string hasEndingVerseInput = Console.ReadLine();

        int? verseEnd = null;
        if (hasEndingVerseInput.ToLower() == "y")
        {
            Console.WriteLine("Enter the ending verse:");
            verseEnd = int.Parse(Console.ReadLine());
        }

        Reference reference = new Reference(book, chapter, verseStart, verseEnd);

        Console.WriteLine("Enter the scripture text (words separated by spaces):");
        string scriptureText = Console.ReadLine();
        List<Word> words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();

        Scripture scripture = new Scripture(reference, words);

        bool allWordsHidden = false;

        while (!allWordsHidden)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Show Scripture");
            Console.WriteLine("2. Hide a Word");
            Console.WriteLine("3. Save Scripture");
            Console.WriteLine("4. Load Scripture");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (scripture != null)
                    {
                        scripture.Show();
                    }
                    else
                    {
                        Console.WriteLine("No scripture loaded.");
                    }
                    break;
                case "2":
                    if (!scripture.HideRandomWord())
                    {
                        Console.WriteLine("All words are hidden. You memorized the scripture!.");
                        allWordsHidden = true;
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter the file name to save scripture:");
                    string fileNameToSave = Console.ReadLine();
                    SaveScripture(scripture, fileNameToSave);
                    Console.WriteLine("Scripture saved successfully.");
                    break;
                case "4":
                    Console.WriteLine("Enter the file name to load scripture:");
                    string fileNameToLoad = Console.ReadLine();
                    scripture = LoadScripture(fileNameToLoad);
                    Console.WriteLine("Scripture loaded successfully.");
                    break;
                case "5":
                    allWordsHidden = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void SaveScripture(Scripture scripture, string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"{scripture.GetReference().GetRenderedText()}");

                foreach (Word word in scripture.GetWords())
                {
                    writer.WriteLine($"{word.GetRenderedText()}|{word.IsHidden()}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving scripture: {ex.Message}");
        }
    }

    static Scripture LoadScripture(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string referenceLine = reader.ReadLine();
                string[] referenceParts = referenceLine.Split(' ');

                string book = string.Join(" ", referenceParts.Skip(1));
                int chapter = int.Parse(referenceParts[2].Split(':')[0]);
                int verseStart = int.Parse(referenceParts[2].Split(':')[1].Split('-')[0]);
                int? verseEnd = referenceParts[2].Contains('-') ? int.Parse(referenceParts[2].Split(':')[1].Split('-')[1]) : (int?)null;

                string scriptureText = reader.ReadLine();
                List<Word> words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();

                Reference reference = new Reference(book, chapter, verseStart, verseEnd);

                return new Scripture(reference, words);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scripture: {ex.Message}");
            return null;
        }
    }
}