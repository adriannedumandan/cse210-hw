// This program allows the user to choose the type of file they want to save.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");

            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.LoadFromFile();
                    break;
                case "4":
                    journal.SaveToFile();
                    break;
                case "5":
                    Console.WriteLine("Thank you. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please pick a number from 1-5.\n");
                    break;        
            }
                
        }
    }
}

