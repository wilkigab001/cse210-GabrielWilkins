using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"{fraction1.GetFractionString()}");
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"{fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");

    }
}