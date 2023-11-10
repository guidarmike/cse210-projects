class ChecklistGoal : Activity
{
    public int TargetCount;
    public int BonusPoints;
    public int _currentCount;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints, string description) : base(name, points, description)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override void MarkComplete()
    {
        if (!Completed)
        {
            _currentCount++;
            if (_currentCount >= TargetCount)
            {
                Completed = true;
            }
        }
    }
}