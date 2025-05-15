using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        // Stretch: Smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();

        // Sort the list
        numbers.Sort();

        // Extra Feature: Median
        double median;
        int count = numbers.Count;
        if (count % 2 == 1)
        {
            median = numbers[count / 2];
        }
        else
        {
            median = (numbers[(count / 2) - 1] + numbers[count / 2]) / 2.0;
        }

        // Extra Feature: Remove Duplicates (Distinct)
        List<int> distinctNumbers = numbers.Distinct().ToList();

        Console.WriteLine($"\nThe sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositive > 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        Console.WriteLine($"The median is: {median}");

        Console.WriteLine("\nThe sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nThe list with duplicates removed:");
        foreach (int n in distinctNumbers)
        {
            Console.WriteLine(n);
        }
    }
}

