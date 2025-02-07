// This program has a library of scripture verses and it randomly selects one scripture to the user.
// The user may press Enter to hide random words or type 'quit' to end the program.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static List<Scripture> scriptureLibrary = new List<Scripture>
    {
        new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him\nshall not perish but have eternal life."),
        new Scripture(new Reference("Mosiah", 3, 19), "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever,\nunless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint\nthrough the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full\nof love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth\nsubmit to his father."),
        new Scripture(new Reference("Doctrine & Covenants", 1, 37, 38), "Search these commandments, for they are true and faithful, and the prophecies and promises which are\nin them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and\nthough the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether\nby mine own voice or by the voice of my servants, it is the same.")
    };

    public static void Main()
    {
        Random random = new Random();
        Scripture scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Program will end.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); 
        }
    }
}
