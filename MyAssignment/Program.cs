// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {

        // Ask the user for their name and greet them
        string userName = UserInput.GetUserInput("Please enter your name: ");
        Console.WriteLine($"Hello, {userName}!");


        // Ask the user for a word and add a hashtag
        string word = UserInput.GetUserInput("Please enter a word:");
        string textWithHashtag = UserInput.AddHashtag(word);
        Console.WriteLine($"Result: {textWithHashtag}");


        // Ask the user for a number
        string number = UserInput.GetUserInput("Please enter a number:");
        Console.WriteLine($"You entered: {number}");


        // Ask the user for a number (alternative approach)
        string userEnteredText = UserInput.GetUserInput("Please enter a number: ");
        Console.WriteLine($"You entered: {userEnteredText}");



        // Ask the user for first and last name and format it
        string firstName = UserInput.GetUserInput("Enter the first name: ");
        string lastName = UserInput.GetUserInput("Enter the last name:");
        string formattedName = UserInput.FormatName(firstName, lastName);
        Console.WriteLine($"Formatted Name: {formattedName}");



    }
}