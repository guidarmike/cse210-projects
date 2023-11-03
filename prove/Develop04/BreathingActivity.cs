class BreathingActivity : Activity
{
    private List<string> _messages =  new List<string> 
    {
        "Breath in...",
        "Breath out..."
    };

    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void ShowMessage()
    {   
        Begin();
        Countdown(2);
        Console.WriteLine("Go!");
        Pause(500);

        int messageIndex = 0;
        int elapsedTime = 0;

        while (elapsedTime + 4 < _duration)
        {
            Console.WriteLine(_messages[messageIndex]);
            Pause(200);
            Countdown(1);
            messageIndex = (messageIndex + 1)% _messages.Count;

            Spinner(4000);
            elapsedTime += 4;
        }
    }
}