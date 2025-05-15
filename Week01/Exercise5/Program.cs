using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        bool keepGoing = true;

        while (keepGoing)
        {
            int userNumber = PromptUserNumber();
            int squared = SquareNumber(userNumber);
            int cubed = CubeNumber(userNumber);

            DisplayResult(userName, userNumber, squared, cubed);

            Console.Write("\nWould you like to try another number? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();
            keepGoing = (response == "yes" || response == "y");
        }

        Console.WriteLine("\nThank you for using the program!");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Function Calculator!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("❌ That wasn't a valid number. Try again.");
            }
        }
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static int CubeNumber(int number)
    {
        return number * number * number;
    }

    static void DisplayResult(string name, int original, int square, int cube)
    {
        Console.WriteLine($"\n{name}, here are your results:");
        Console.WriteLine($"• Original number: {original}");
        Console.WriteLine($"• Squared: {square}");
        Console.WriteLine($"• Cubed: {cube}");
    }
}

