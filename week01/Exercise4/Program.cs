

class Program
{
    static void Main(string[] args)
    {   
        List<int>UserNumbers = new List<int>();
        Console.WriteLine("Enter a list of Numbers, type 0 when finished.");

        int InputNumber = -2;

        while(InputNumber != 0){
            Console.Write("Enter a number(0 to quit):");
            InputNumber = int.Parse(Console.ReadLine());

            if(InputNumber != 0){
                UserNumbers.Add(InputNumber);
            }
        }

        int TotalSum = 0;
        foreach(int number in UserNumbers){
            TotalSum += number;
        }

        float AverageNumber = ((float)TotalSum) / UserNumbers.Count;

        int LargestNumber = UserNumbers[0];

        foreach( int number in UserNumbers){
            if(number > LargestNumber){
                LargestNumber = number;
            }
        }
        Console.WriteLine($"The sum is: {TotalSum}");
        Console.WriteLine($"The Average is: {AverageNumber}");
        Console.WriteLine($"The Largest Number is: {LargestNumber}");
    }   
}