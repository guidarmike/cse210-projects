class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Lecture\nSpeaker: {GetSpeaker()}\nCapacity: {GetCapacity()}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Lecture\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }

    private string GetSpeaker()
    {
        return _speaker;
    }

    private int GetCapacity()
    {
        return _capacity;
    }
}