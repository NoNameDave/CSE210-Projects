public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _goalAmount;
    private int _currentAmount;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string type, string name, string description, int points):base(type,name,description,points)
    {

    }

    public ChecklistGoal(string type, string name, string description, int points, int bonus, int goalAmount, int currentAmount):base(type,name,description,points)
    {
        _bonus = bonus;
        _goalAmount = goalAmount;
        _currentAmount = currentAmount;
    }

    public int Bonus
    {
        get{return _bonus;}
        set{_bonus = value;}
    }

    public int GoalAmount
    {
        get{return _goalAmount;}
        set{_goalAmount = value;}
    }

    public int CurrentAmount
    {
        get{return _currentAmount;}
        set{_currentAmount = value;}
    }

    public override string SaveGoal()
    {
        string goalString = ($"{Type}|{Name}|{Description}|{Points}|{Bonus}|{GoalAmount}|{CurrentAmount}");
        return goalString;
    }

    public int GetGoalAmount()
    {
        Console.WriteLine("How many times does this goal need to be done for a bonus?");
        string goalAmountString = Console.ReadLine();
        int goalAmount = Int32.Parse(goalAmountString);
        return goalAmount;
    }

    public int GetBonus()
    {
        Console.WriteLine("Enter the amount for accomplishing it that many times: ");
        string bonusString = Console.ReadLine();
        int bonus = Int32.Parse(bonusString);
        return bonus;
    }
}