using System;

public class Running : Activity
{
    private double distance; // Distance in miles

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / GetDuration()) * 60;

    public override double GetPace() => GetDuration() / distance;

    public override string GetSummary()
    {
        return $"{base.GetSummary()} (Running) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
