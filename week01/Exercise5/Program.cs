using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string UserName = PromptUserName();

        int favNumber = PromptUserNumber();
        int squareNumber = SquaredNumber(favNumber);

        DisplayResult(UserName, squareNumber);
    }

    static void DisplayWelcomeMessage(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.Write("Please Enter your Name:");
        string UserName = Console.ReadLine();

        return UserName;
    }

    static int PromptUserNumber(){
        Console.Write("Whats your favorite number? ");

        int FavNumber = int.Parse(Console.ReadLine());

        return FavNumber;
    }

    static int SquaredNumber(int FavNumber){
        return FavNumber * FavNumber;
    }

    static void DisplayResult(string UserName, int SquareNumber){
        Console.WriteLine($"{UserName}, the square of your number is {SquareNumber}");
    }

}