public abstract class Activity
{
    private DateTime _date;
    private double _Minutes;

    private double _distance;

    public Activity(double Minutes, double distance)
    {
        _date = DateTime.Now;
        _Minutes = Minutes;
        _distance = distance;
    }


    public DateTime GetDate()
    {
        return _date;
    }
    
    public double GetDistance()
    {
        return _distance;
    }

    public double GetLengthInMinutes()
    {
        return _Minutes;
    }

    public abstract string GetSummary();
}