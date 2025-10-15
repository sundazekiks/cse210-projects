public class Bicycle : Activity
{
    private double _speed;
    
    public Bicycle(double speed, double lengthInMinutes, double distance) : base(lengthInMinutes, distance)
    {
        _speed = distance / (lengthInMinutes / 60);
    }



    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Bicycling ({GetLengthInMinutes()} min) - Distance: {GetDistance()} km, Speed: {60 / (GetLengthInMinutes() / GetDistance())} kph, Pace: {GetLengthInMinutes() / GetDistance()} min per km";
    }
}