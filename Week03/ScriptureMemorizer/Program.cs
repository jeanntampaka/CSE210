using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            scripture.HideRandomWords(random, 3); // Hide 3 random visible words
        }
    }

    static List<Scripture> LoadScriptures(string filePath)
    {
        var scriptures = new List<Scripture>();
        foreach (string line in File.ReadAllLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            string[] parts = line.Split('|');
            if (parts.Length != 2) continue;

            ScriptureReference reference = new ScriptureReference(parts[0]);
            scriptures.Add(new Scripture(reference, parts[1]));
        }
        return scriptures;
    }
}

/*
 * Exceeds requirements by:
 * - Loading multiple scriptures from a file
 * - Selecting a scripture at random
 * - Avoiding already hidden words when selecting random ones to hide
 * - Provides modular and clean design using principles of encapsulation
 */
