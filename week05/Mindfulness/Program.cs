public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start positive affirmations activity");
            Console.WriteLine("5. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new Breathing();
                    break;
                case "2":
                    activity = new Reflection();
                    break;
                case "3":
                    activity = new Listing();
                    break;
                case "4":
                    activity = new PositiveAffirmations();
                    break;
                case "5":
                    return; 
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowSpinner(3); 
                    continue;
            }

            if (activity != null)
            {
                activity.Start();
            }
        }
    }

    private static void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
