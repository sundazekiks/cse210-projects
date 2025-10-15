
public class Running : Activity
{

    private double _distance;

    public Running(double distance, double lengthInMinutes) : base(lengthInMinutes, distance)
    {
        _distance = distance;
    }
    
    public override string GetSummary()
    {

        return $"{GetDate().ToString("dd MMM yyyy")} Running ({GetLengthInMinutes()} min)  - Distance: {_distance} km, Speed: {60 / (GetLengthInMinutes() / _distance)} kph, Pace: {GetLengthInMinutes() / _distance} min per km";
    }
}