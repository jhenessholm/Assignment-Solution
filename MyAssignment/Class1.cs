using System;
using System.Diagnostics.Metrics;
using System.Numerics;

using System;

public class UserInput
{
    public static string GetUserInput (string message)
    {
        Console.WriteLine(message);
        string userText = Console.ReadLine().Trim();
        while (string.IsNullOrEmpty(userText))
        {
            Console.WriteLine("Input cannot be empty. Please try again.");
            Console.WriteLine(message);
            userText = Console.ReadLine().Trim();
        }
        return userText;
    }


    public static string AddHashtag(string word)
    {
        Console.Write($"Enter some text for #{word}: ");
        string userText = Console.ReadLine().Trim();
        while (string.IsNullOrEmpty(userText))
        {
            Console.WriteLine("Input cannot be empty. Please try again.");
            Console.Write($"Enter some text for #{word}: ");
            userText = Console.ReadLine().Trim();
        }
        string result = $"#{userText}";
        return result;
    }
    public static string FormatName(string firstName, string lastName)
    {
        string fullName = $"{lastName}, {firstName}";
        return fullName;
    }
}