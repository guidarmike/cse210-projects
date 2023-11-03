using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //To exceed the requirements an option to track how many times the activities were selected was added
        //by setting variables that would track how many times the user selected each activity
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        string choice = "";

        while (choice != "4. Quit")
        {
            Console.WriteLine("Mindfulness Activity Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Display Activity Counts");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an activity (1-5): ");

            choice = Console.ReadLine();

            if (int.TryParse(choice, out int activityChoice))
            {
                if (activityChoice >= 1 && activityChoice <= 3)
                {
                    switch (activityChoice)
                    {
                        case 1:
                            breathingCount++;
                            break;
                        case 2:
                            reflectionCount++;
                            break;
                        case 3:
                            listingCount++;
                            break;
                    }

                    Console.Write("Enter the duration (in seconds): ");
                    if (int.TryParse(Console.ReadLine(), out int duration))
                    {
                        Activity activity = null;

                        switch (activityChoice)
                        {
                            case 1:
                                activity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
                                activity.SetDuration(duration);
                                ((BreathingActivity)activity).ShowMessage();
                                break;
                            case 2:
                                activity = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                                activity.SetDuration(duration);
                                ((ReflectionActivity)activity).RandomPrompt();
                                break;
                            case 3:
                                activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                                activity.SetDuration(duration);
                                ((ListingActivity)activity).Start();
                                break;
                        }

                        Console.WriteLine();
                        Console.WriteLine(activity.Done());

                    }
                    else
                    {
                        Console.WriteLine("Invalid duration input.");
                    }
                }
                else if (activityChoice == 4)
                {
                    Console.WriteLine($"You did so far:");
                    Console.WriteLine($"{breathingCount} times the Breathing Activity");
                    Console.WriteLine($"{reflectionCount} times the Reflection Activity");
                    Console.WriteLine($"{listingCount} times the Listing Activity");
                    Console.WriteLine();
                }
                else if (activityChoice == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid menu choice.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}