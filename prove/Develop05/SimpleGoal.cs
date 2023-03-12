public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal()
    {

    }

    public SimpleGoal(string type, string name, string description, int points, bool isComplete):base(type,name,description,points)
    {
        _isComplete = isComplete;
    }

    public bool IsComplete
    {
        get{return _isComplete;}
        set{_isComplete = value;}
    }

    public override string SaveGoal()
    {
        string goalString = ($"{Type}|{Name}|{Description}|{Points}|{IsComplete}");
        return goalString;
    }

}