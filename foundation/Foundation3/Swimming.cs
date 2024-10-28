using System;

public class Swimming : Activity
{
    private int laps; // Number of laps, each lap is 50 meters

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0 * 0.62; // Convert meters to miles

    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;

    public override double GetPace() => GetDuration() / GetDistance();

    public override string GetSummary()
    {
        return $"{base.GetSummary()} (Swimming) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
