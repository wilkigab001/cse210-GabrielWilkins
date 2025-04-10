public class SimpleGoal : Goal{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points):base(name, description, points){
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if(!_isComplete){
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringToSave()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    }

    public override void LoadFromString(string data)
    {
        var parts = data.Split('|');
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);

    }
}