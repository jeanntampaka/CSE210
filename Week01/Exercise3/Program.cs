using System;
using System.Collections.Generic;

class Program
{
    // Function to ask for a name and return a formatted full name
    static string GetFullName()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        return $"{firstName} {lastName}";
    }

    static void Main()
    {
        List<string> fullNames = new List<string>();
        string choice;

        do
        {
            string fullName = GetFullName();

            // Condition: only add if both names are not empty
            if (!string.IsNullOrWhiteSpace(fullName))
            {
                fullNames.Add(fullName);
            }

            Console.Write("Do you want to enter another name? (yes/no): ");
            choice = Console.ReadLine().ToLower();

        } while (choice == "yes");

        Console.WriteLine("\nCollected Names:");
        foreach (string name in fullNames)
        {
            Console.WriteLine(name);
        }
    }
}

