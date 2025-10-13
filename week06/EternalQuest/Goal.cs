public class Goal
{
    private string GoalName;
    private string ShortDescription;
    private int AmountOfPoints;

    private int TimesToComplete;
    
    private bool IsCompleted = false;

    public Goal(string goalName, string shortDesription, int amountOfPoints, int times)
    {
        GoalName = goalName;
        ShortDescription = shortDesription;
        AmountOfPoints = amountOfPoints;
        TimesToComplete = times;
    }

    public bool getIfCompleted()
    {
        return IsCompleted;
    }

    public void setIfCompleted()
    {
        IsCompleted = true;
    }

    public int getTimesToComplete()
    {
        return TimesToComplete;
    }

    public string getGoalName()
    {
        return GoalName;
    }
    public string getShortDescription()
    {
        return ShortDescription;
    }
    public int getAmountOfPoints()
    {
        return AmountOfPoints;
    }

    public virtual string getSummaryOfGoal()
    {
        return $"{GoalName} | {ShortDescription} | {AmountOfPoints} Points";
    }

    public virtual string getType()
    {
        return GoalName;
    }

}