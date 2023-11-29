using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Creating videos and adding comments
        Video video1 = new Video("Italian Style Lisagna", "Italian Kitchen", 1200);
        video1.AddComment("GarfieldTheDogNotTheCat", "I am asking for a friend: where did you place that lasagna?");
        video1.AddComment("Marvin Cook", "Look delicious!");
        video1.AddComment("Caleb the Italian", "Are you sure that is that the way you make it?");

        Video video2 = new Video("1 hour of silence occasionally broken up by fart with extra reverb", "The Fart Memes", 3615);
        video2.AddComment("NotAnUser", "Nice work!");
        video2.AddComment("Brad McGregor", "I learned a lot.");
        video2.AddComment("Dart InSlidingDMs", "The force is strong with the one at 39:44.");

        Video video3 = new Video("How to find happiness during hard times", "Inspirational Quotes", 1028);
        video3.AddComment("Carla Montana", "Amazing video!");
        video3.AddComment("Alex Greetings", "It is what I needed after being laid off...");
        video3.AddComment("Savanna Nelson", "IT'S TRUE!! When we are emotionally weak we can easily turn to bad habits and stop respecting healthy schedule or personal routines that help us be the better version of ourselves.");

        // Adding videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Displaying information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Displaying all comments for the video
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}