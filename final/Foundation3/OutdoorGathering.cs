class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Outdoor Gathering\nWeather: {GetWeatherStatement()}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }

    private string GetWeatherStatement()
    {
        return _weatherStatement;
    }
}
