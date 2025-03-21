using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Enos", 1, 27);
        var scripture = new Scripture(reference, "And I soon go to the place of my rest, which is with my redeemer; for I know that in him I shall rest. And I rejoice in the day when my mortal shall put on immortality, and then shall stand before him; then shall I see his face with pleasure, and he will say unto me: Come unto me, ye blessed, there is a place prepared for you in the mansions of my Father. Amen.");

        while(true){
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if(scripture.IsCompletelyHidden()){
                break;
            }

            Console.WriteLine("Press enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if(input == "quit"){
                 break;
            }

            scripture.HideRandomWords(4);

        }
    }
}