class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    protected DateTime _startTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void Begin()
    {
        _startTime = DateTime.Now;
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Pause(300);
        }
    }

    public void Spinner(int milliseconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;
        DateTime start = DateTime.Now;

        while (DateTime.Now.Subtract(start).TotalMilliseconds < milliseconds)
        {
            Console.Write($"\r{spinner[index++ % spinner.Length]}");
            Pause(200);
            Console.Write($"\r{new string(' ', spinner[0].Length)}");
        }

        Console.WriteLine();
    }

    public string Done()
    {
        return $"Great job! You have completed the {_name} activity in {_duration} seconds.";
    }

    public int GetCurrentTime()
    {
        DateTime now = DateTime.Now;
        TimeSpan elapsedTime = now - _startTime;
        return _duration - (int)elapsedTime.TotalSeconds;
    }
}