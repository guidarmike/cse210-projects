using System;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            PlayGame();

            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine().ToLower();
        } while (response == "yes");

        static void PlayGame()
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int numberOfGuesses = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numberOfGuesses++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it! You did it after " + numberOfGuesses + " guesses.");
                }
            }
        }
    }
}