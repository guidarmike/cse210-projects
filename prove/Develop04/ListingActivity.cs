class ListingActivity : Activity
{
    private List<string> _userList;
    private List<string> _startingMessages = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
        _userList = new List<string>();

    }

    public void RandomPrompt()
    {
        Random random = new Random();
        string prompt = _startingMessages[random.Next(_startingMessages.Count)];
        Console.WriteLine(prompt);
        Countdown(10);
    }

    public void AddToList(string item)
    {
        _userList.Add(item);
    }

    public int GetListCount()
    {
        return _userList.Count;
    }

    public void Start()
    {   
        Begin();
        RandomPrompt();
        Console.WriteLine("Go!");

        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            if (GetCurrentTime() <= 0)
            {    
                break;
            }

            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            AddToList(item);
            Console.WriteLine($"Added: {item}");

            elapsedTime += 3;
        }

        Console.WriteLine($"You listed {GetListCount()} items.");
    }
}