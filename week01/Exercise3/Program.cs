using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int magic = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magic)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess <= magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess >= magic)
            {
                Console.WriteLine("Lower");
            }
        }
        
    }
}