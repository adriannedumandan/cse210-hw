using System;

public abstract class Activity
{
    private DateTime Date { get; set; }
    private int Minutes { get; set; }

    public Activity(DateTime date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    
    protected int ActivityMinutes
    {
        get { return Minutes; }
    }

    public abstract double GetDistance();  
    public abstract double GetSpeed();     
    public abstract double GetPace();      

    public string GetSummary()
    {
        string summary = $"\n{Date.ToString("dd MMM yyyy")} ";
        summary += $"{this.GetType().Name} ({Minutes} min): ";
        summary += $"Distance: {GetDistance():0.0} miles, ";
        summary += $"Speed: {GetSpeed():0.0} mph, ";
        summary += $"Pace: {GetPace():0.0} min per mile";
        return summary;
    }
}
