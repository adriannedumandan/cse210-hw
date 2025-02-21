public class Swimming : Activity
{
    private int Laps { get; set; }  

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000 * 0.62; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / ActivityMinutes) * 60;  
    }

    public override double GetPace()
    {
        return ActivityMinutes / GetDistance();  
    }
}
