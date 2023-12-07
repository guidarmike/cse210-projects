using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        Running runningActivity = new Running("05 Dec 2023", 40, 30.0);
        Cycling cyclingActivity = new Cycling("01 Dec 2023", 30, 40.0);
        Swimming swimmingActivity = new Swimming("28 Nov 2023", 20, 30);

        // Add activities to the list
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}