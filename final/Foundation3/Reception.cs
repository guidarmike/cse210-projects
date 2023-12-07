class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Reception\nRSVP Email: {GetRsvpEmail()}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Reception\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }

    private string GetRsvpEmail()
    {
        return _rsvpEmail;
    }
}