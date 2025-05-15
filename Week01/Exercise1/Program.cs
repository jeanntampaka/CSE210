using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fullNames = new List<string>();

        while (true)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            string fullName = GetFullName(firstName, lastName);
            fullNames.Add(fullName);

            Console.WriteLine($"Hello, {fullName}!");

            Console.Write("Would you like to add another name? (yes/no): ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
            {
                break;
            }
        }

        Console.WriteLine("\nAll names entered:");
        foreach (string name in fullNames)
        {
            Console.WriteLine(name);
        }
    }

    static string GetFullName(string first, string last)
    {
        return first + " " + last;
    }
}
