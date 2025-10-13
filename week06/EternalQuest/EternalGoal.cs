public class EternalGoal : Goal
{
    private string _typeOfGoal;


    public EternalGoal(string name, string shortDesription, int AmountOfPoints) : base(name, shortDesription, AmountOfPoints, 0)
    {
        _typeOfGoal = "Eternal Goal";
    }

    public override string getSummaryOfGoal()
    {
        return $"{_typeOfGoal} | {base.getSummaryOfGoal()}";
    }
    
    public override string getType()
    {
        return _typeOfGoal;
    }
}