using System;

class Program
{
    static void Main()
    {
        int grade = 0;
        bool validInput = false;

        // Keep asking for a valid grade until the user provides one
        while (!validInput)
        {
            Console.Write("Enter your grade percentage: ");
            string input = Console.ReadLine();

            // Validate the input
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }

        string letter = "";
        string sign = "";

        // Determine letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine sign
        int lastDigit = grade % 10;

        if (letter != "F")
        {
            if (lastDigit >= 7 && grade < 100)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }

            // Remove "+" from A+
            if (letter == "A")
            {
                sign = lastDigit < 3 ? "-" : "";
            }
        }

        // Print the result
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Pass/Fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Keep working hard — you'll do better next time!");
        }
    }
}
