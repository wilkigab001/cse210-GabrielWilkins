
public abstract class Goal{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string description, string name, int points){
        _description = description;
        _name = name;
        _points = points; 
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString(){
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description})";
    }

    public abstract string GetStringToSave();
    public abstract void LoadFromString(string data);
}