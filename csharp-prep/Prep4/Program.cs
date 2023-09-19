using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        int smallestPositive = int.MaxValue; // Initialize to a large value

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the list using a custom sorting algorithm (e.g., bubble sort)
        SortList(numbers);

        Console.WriteLine("Sorted list:");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
    }

    static void SortList(List<int> list)
    {
        int n = list.Count;
        bool swapped;

        do
        {
            swapped = false;

            for (int i = 1; i < n; i++)
            {
                if (list[i - 1] > list[i])
                {
                    // Swap list[i-1] and list[i]
                    int temp = list[i - 1];
                    list[i - 1] = list[i];
                    list[i] = temp;
                    swapped = true;
                }
            }

        } while (swapped);
    }
}
