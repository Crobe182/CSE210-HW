public class Swimming : Activity
{
    private int _laps; // Number of laps (each lap is 50 meters)

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; // In miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}