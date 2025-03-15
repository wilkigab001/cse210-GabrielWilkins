public class PromptGenerator{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person i interacted with today?",
        "What are you grateful for today?",
        "Describe a challenge you faced and how you overcame it.",
        "How did I see the hand of the lord in my day today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
