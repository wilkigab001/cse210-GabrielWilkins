using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        while(true){
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string Choice = Console.ReadLine();

            if(Choice == "1"){
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                string response = Console.ReadLine();
                journal.AddEntry(new Entry(DateTime.Now.ToString("yyyy-mm-dd"), prompt, response));
            }
            else if (Choice == "2"){
                journal.DisplayAll();
            }
            else if(Choice == "4"){
                Console.WriteLine("What is the File to save to?");
                string FileToUse = Console.ReadLine();
                journal.SaveToFile(FileToUse);
            }
            else if(Choice == "3"){
                Console.WriteLine("What is the file to load from?");
                string FileToLoad = Console.ReadLine();
                journal.LoadFromFile(FileToLoad);
                
            }
            else if(Choice == "5"){
                return;
            }
            else{
                Console.WriteLine("Invalid Response. Please Try Again.");
            }
        }

    }
}