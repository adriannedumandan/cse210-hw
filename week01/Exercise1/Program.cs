using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.Write("What is your first name? "); 
        string name = Console.ReadLine();
        Console.Write("What is your last name? "); 
        string surname = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {surname}, {name} {surname}.");
    }
}