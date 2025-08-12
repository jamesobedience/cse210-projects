using System;

public abstract class Activity
{
    private DateTime _date;
    private int _duration; 

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime Date => _date;
    public int Duration => _duration;

    public abstract double GetDistance(); 
    public abstract double GetSpeed();   
    public abstract double GetPace();     

    public virtual string GetSummary()
    {
        string activityName = this.GetType().Name;
        return $"{_date:dd MMM yyyy} {activityName} ({_duration} min) - " +
               $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}
// This abstract class represents a generic activity with properties for date and duration,