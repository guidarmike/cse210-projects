using System;
using System.Collections.Generic;
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

        Reference reference = new Reference(book, chapter, verseStart);

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
            Console.WriteLine("3. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    scripture.Show();
                    break;
                case "2":
                    if (!scripture.HideRandomWord())
                    {
                        Console.WriteLine("All words are hidden. You memorized the scripture!.");
                        allWordsHidden = true;
                    }
                    break;
                case "3":
                    allWordsHidden = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}