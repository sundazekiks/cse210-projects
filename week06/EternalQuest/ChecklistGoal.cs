public class ChecklistGoal : Goal
{
    private string _typeOfGoal;

    private int reps = 0;

    public ChecklistGoal(string name, string shortDesription, int AmountOfPoints, int times) : base(name, shortDesription, AmountOfPoints, times)
    {
        _typeOfGoal = "Checklist Goal";
        reps = times;
    }

    public override string getSummaryOfGoal()
    {
        return $"{_typeOfGoal} | {base.getSummaryOfGoal()} | Reps Left: {reps}";
    }
    
    public override string getType()
    {
        return _typeOfGoal;
    }

    public int getNumberOfRepsLeft(){
        return reps;
    }

    public void addReps(int number){
        reps = number;
    }

    public void reduceReps(){
        reps -= 1;
    }


}