class User
{
    public int _score;
    public List<Activity> _goals;
    private int _level;

    public User()
    {
        _score = 0;
        _goals = new List<Activity>();
        _level = 0;
    }

    public List<Activity> GetGoals()
    {
        return _goals;
    }

    public int GetScore()
    {
        return _score;
    }

    public int GetLevel()
    {
        return _level;
    }

    public void UpdateLevel()
    {
        int[] levelThresholds = {200, 500, 1000, 2000, 3000};

        for (int i = levelThresholds.Length - 1; i >= 0; i--)
        {
            if (_score >= levelThresholds[i])
            {
                if (_level < i + 1)
                {
                    _level = i + 1;
                    Console.WriteLine($"Congratulations! You've reached Level {_level}!");
                }
                break;
            }
        }
    }
}