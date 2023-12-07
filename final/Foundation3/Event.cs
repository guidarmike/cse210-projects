class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GenerateStandardDetails()
    {
        return $"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}\nTime: {GetTime()}\nAddress: {GetAddress()}";
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Type: Generic Event\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }

    protected string GetTitle()
    {
        return _title;
    }

    protected string GetDescription()
    {
        return _description;
    }

    protected string GetDate()
    {
        return _date.ToShortDateString();
    }

    protected TimeSpan GetTime()
    {
        return _time;
    }

    protected string GetAddress()
    {
        return _address.GetAddress();
    }
}