using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string FirstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string LastName = Console.ReadLine();

        Console.Write($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}