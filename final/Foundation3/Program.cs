using System;

class Program
{
    static void Main()
    {
        // Creating an instance of each event type with a specific date
        DateTime lectureDate = new DateTime(2023, 12, 18);
        DateTime receptionDate = new DateTime(2023, 12, 24);
        DateTime outdoorGatheringDate = new DateTime(2023, 12, 31);

        Lecture lecture = new Lecture("Modern Reality of Depression", "A talk through how we got here emotionally", lectureDate, new TimeSpan(17, 0, 0), new Address("123 Main St", "Cityville", "CA", "12345"), "Jordan B. Peterson", 750);

        Reception reception = new Reception("Grand Christmas' Eve Dinner", "An elegant dinner in remembrance of this joyous day", receptionDate, new TimeSpan(18, 30, 0), new Address("456 Oak St", "Townsville", "NY", "67890"), "town.hall@yahoo.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering("New Year's Eve", "Casual last night for this 2023", outdoorGatheringDate, new TimeSpan(21, 0, 0), new Address("789 Pine St", "Villageton", "TX", "54321"), "Sunny skies expected");

        // Calling methods to generate marketing messages and outputting the results
        Console.WriteLine("Standard Details:\n");
        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:\n");
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Descriptions:\n");
        Console.WriteLine(lecture.GenerateShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortDescription());
    }
}