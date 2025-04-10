public class GoalManager{
    private List<Goal> _goals  = new List<Goal>();
    private int _score = 0;

    private int _level = 1;
    private int XP = 0;

    public void AddXP(int points){
        XP += points;
        int xpNeeded = _level * 5;
        while(XP >= xpNeeded){
            XP -= xpNeeded;
            _level++;
            Console.WriteLine($"Congrats! You are now level {_level}");
            xpNeeded = _level * 5;
        } 
    }

    public void CreateGoal(){
        Console.WriteLine("Choose Goal Type: \n 1: Simple \n 2: Eternal \n 3: Checklist");
        string choice = Console.ReadLine();

        Console.WriteLine("Goal Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Goal Description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Amount of Points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;


        if(choice == "1"){
            goal = new SimpleGoal(name, description, points);
        }else if(choice == "2"){
            goal = new EternalGoal(name, description, points);
        }else  if(choice == "3"){
            Console.Write("Target Count : ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Bonus Points :" );
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if(goal != null){
            _goals.Add(goal);
        }
    }

    public void RecordEvent(){
        Console.WriteLine("Choose a Goal: ");
        for(int i = 0; i<_goals.Count; i++){
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;
        int earned = _goals[index].RecordEvent();
        _score += earned;
        AddXP(earned);

        Console.WriteLine($"You earned {earned} points!");
    }

        public void ShowGoals()
    {
        foreach (var goal in _goals)
            Console.WriteLine(goal.GetDetailString());

        Console.WriteLine($"Total score: {_score}");
    }

    public void SaveGoals()
    {
        List<string> lines = new List<string> { _score.ToString() };
        lines.AddRange(_goals.Select(g => g.GetStringToSave()));
        File.WriteAllLines("goals.txt", lines);
        Console.WriteLine("Saved.");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved file found.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            Goal goal = parts[0] switch
            {
                "Simple" => new SimpleGoal("", "", 0),
                "Eternal" => new EternalGoal("", "", 0),
                "Checklist" => new ChecklistGoal("", "", 0, 0, 0),
                _ => null
            };

            if (goal != null)
            {
                goal.LoadFromString(lines[i]);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Loaded.");
    }
}