using System;

public abstract class Activity
{
    private DateTime date;
    private int duration; // duration in minutes

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public int GetDuration() => duration;

    public virtual double GetDistance() => 0; // Placeholder, to be overridden
    public virtual double GetSpeed() => 0;    // Placeholder, to be overridden
    public virtual double GetPace() => 0;     // Placeholder, to be overridden

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} Activity ({duration} min) - Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
