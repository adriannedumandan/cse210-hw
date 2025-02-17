public class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void Run()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4); 
            Console.Write("Now breathe out... ");
            ShowCountdown(4); 
            elapsed += 8;
        }
    }
}
