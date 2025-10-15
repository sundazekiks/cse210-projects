public class Swimming : Activity
{
   
   private int _laps;

    public Swimming(int laps, double lengthInMinutes, double distance = 0) : base(lengthInMinutes, distance)
    {
        _laps = laps;
    }
    
   
    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({GetLengthInMinutes()} min) - Distance: {(_laps * 50) / 1000} km, Speed: {60 / (GetLengthInMinutes() / ((_laps * 50) / 1000))} kph, Pace: {GetLengthInMinutes() / ((_laps * 50) / 1000)} min per km, Laps: {_laps}";
    }
}