class User
{
    public int _score;
    public List<Activity> _goals;

    public User()
    {
        _score = 0;
        _goals = new List<Activity>();
    }

    public List<Activity> GetGoals()
    {
        return _goals;
    }

    public int GetScore()
    {
        return _score;
    }
}