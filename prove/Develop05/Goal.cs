public abstract class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private int _points;

    List<string> _goalList = new List<string>();

    public Goal()
    {

    }

    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    public List<string> GetList()
    {
        return _goalList;
    }

    public void SetList(List<string> list)
    {
        _goalList = list;
    }

    public string Type
    {
        get{return _type;}
        set{_type = value;}
    }

    public string Name
    {
        get{return _name;}
        set{_name = value;}
    }

    public string Description
    {
        get{return _description;}
        set{_description = value;}
    }

    public int Points
    {
        get{return _points;}
        set{_points = value;}
    }

    public string GetGoalName()
    {
        Console.WriteLine("Enter the name of your goal: ");
        Name = Console.ReadLine();
        return Name;
    }
    public string GetGoalDescription()
    {
        Console.WriteLine("Enter a short description: ");
        Description = Console.ReadLine();
        return Description;
    }
    public int GetGoalPoints()
    {
        bool isNumber = false;

        while (isNumber == false)
        {
            Console.WriteLine("Enter the points value of your goal: ");

            string points = Console.ReadLine();
            if (int.TryParse(points, out _points))
            {
                isNumber = true;
            }
            else 
            {
                Console.WriteLine("Not a valid number, please try again.");
            }
        }
            return _points;
    }

    public abstract string SaveGoal();

}