using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string Score = Console.ReadLine();
        int ScorePercent = int.Parse(Score);
        string letter = "";

        if(ScorePercent >= 90)
        {
            letter = "A";
        }
        else if(ScorePercent >= 80){
            letter = "B";
        }
        else if (ScorePercent >= 70)
        {
            letter = "C";
        }
        else if(ScorePercent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your Letter grade is {letter}");

        if (ScorePercent >= 70)
        {
            Console.Write("Congrats you Passed the course");
        }
        else
        {
            Console.Write("Better Luck Next Time");
        }
    }
}