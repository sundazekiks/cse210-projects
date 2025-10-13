public class SimpleGoal : Goal
{
    private string _typeOfGoal;


    public SimpleGoal(string name, string shortDesription, int AmountOfPoints) : base(name, shortDesription, AmountOfPoints, 0)
    {
        _typeOfGoal = "Simple Goal";
    }

    public override string getSummaryOfGoal()
    {
        return $"{_typeOfGoal} |{base.getSummaryOfGoal()}";
    }

    public override string getType()
    {
        return _typeOfGoal;
    }
    
}