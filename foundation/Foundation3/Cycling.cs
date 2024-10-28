using System;

public class Cycling : Activity
{
    private double speed; // Speed in mph

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetSpeed() => speed;

    public override double GetDistance() => (speed * GetDuration()) / 60;

    public override double GetPace() => 60 / speed;

    public override string GetSummary()
    {
        return $"{base.GetSummary()} (Cycling) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
