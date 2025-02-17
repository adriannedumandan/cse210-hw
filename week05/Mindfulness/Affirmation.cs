// This program includes an activity that helps the user think of positive affirmations about herself and allow her to list them.

public class PositiveAffirmations : Activity
{
    private static List<string> prompts = new List<string>
    {
        "Think about your strengths and write them down.",
        "Reflect on your accomplishments and write positive affirmations.",
        "Consider the qualities that make you unique and special."
    };

    public PositiveAffirmations() : base("Positive Affirmations Activity", "This activity will help you build a positive self-image by focusing on affirmations and kind words about yourself. Take a moment to reflect on your strengths, qualities, and accomplishments, and write down positive affirmations.")
    {
    }

    protected override void Run()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine("\nReflect and write down your responses to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        List<string> affirmations = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.Write("> ");
            string affirmation = Console.ReadLine();
            if (!string.IsNullOrEmpty(affirmation))
            {
                affirmations.Add(affirmation);
            }
        }

        Console.WriteLine($"\nYou listed {affirmations.Count} positive affirmations!");
    }
}
