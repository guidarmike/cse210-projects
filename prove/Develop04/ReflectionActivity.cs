class ReflectionActivity : Activity
{
    private List<string> _startingMessages = new List<string>
    {
        "--- Think of a time when you stood up for someone else. ---",
        "--- Think of a time when you did something really difficult. ---",
        "--- Think of a time when you helped someone in need. ---",
        "--- Think of a time when you did something truly selfless. ---"
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }

    public void RandomPrompt()
    {
        Begin();
        Countdown(2);
        Console.WriteLine("Go!");

        int elapsedTime = 0;
        Random random = new Random();
        string prompt = _startingMessages[random.Next(_startingMessages.Count)];
        Console.WriteLine(prompt);
        Countdown(4);

        while (elapsedTime < _duration)
        {
            foreach (string question in _questions)
            {
                int remainingTime = _duration - elapsedTime;
                if (remainingTime <= 0)
                    break;

                Console.WriteLine(question);

                if (remainingTime > 10)
                {
                    Spinner(9000);
                    elapsedTime += 9;
                }
                else
                {
                    Spinner(remainingTime * 1000);
                    elapsedTime = _duration;
                }

            }
        }
    }


    public void ReflectionQuestionPrompt(int elapsedTime)
    {
        if (_questions.Count == 0)
        {
            return;
        }

        int timePerQuestion = (_duration - elapsedTime) / _questions.Count;

        for (int i = 0; i < _questions.Count; i++)
        {
            Console.WriteLine(_questions[i]);

            if (i < _questions.Count - 1)
            {
                int remainingTime = _duration - elapsedTime;
                int pauseTime = Math.Min(remainingTime - timePerQuestion, 8000);
                Spinner(pauseTime);
                elapsedTime += timePerQuestion + pauseTime;
            }
        }
    }
}