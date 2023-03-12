using System;
using System.IO;

class Program
{
    static List<Goal> goalObjectsList = new List<Goal>();
    static List<string> currentGoalsAdded = new List<string>();
    static int points = 0;
    static int menuWidth = 40;
    static string newLine = "newLine";
    static string midLine = "midLine";
    static string endLine = "endLine";
    static void Main(string[] args)
    {
        static int MainMenu()
        {   
            PrettifyLines(newLine);
            CenterString("ETERNAL GOAL PROGRAM");
            DisplayPoints();
            PrettifyLines(midLine);
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Create new goal.");
            Console.WriteLine("2. List goals.");
            Console.WriteLine("3. Save goals.");
            Console.WriteLine("4. Load goals.");
            Console.WriteLine("5. Record event.");
            Console.WriteLine("6. Quit.");
            PrettifyLines(midLine);
            Console.Write("Select an option from the menu: ");
            string input = Console.ReadLine();
            int choice = int.Parse(input);
            return choice;
        }

        int userInput = 0;
        do
        {
            userInput = MainMenu();
            if (userInput == 1)
            {   
                Console.WriteLine("The Type of goals are: ");
                Console.WriteLine("1. Simple goal.");
                Console.WriteLine("2. Eternal goal.");
                Console.WriteLine("3. Checklist goal.");
                Console.Write("What type of goal would you like to create? ");
                string input = Console.ReadLine();
                int choice = int.Parse(input);
                int goalChoice = 0;
                do
                {
                    goalChoice = choice;
                    if (goalChoice == 1)
                        {
                        SimpleGoal simpleGoal =new SimpleGoal();
                        simpleGoal.Type = "Simple Goal";
                        simpleGoal.Name = simpleGoal.GetGoalName();
                        simpleGoal.Description = simpleGoal.GetGoalDescription();
                        simpleGoal.Points = simpleGoal.GetGoalPoints();
                        simpleGoal.IsComplete = false;
                        SimpleGoal goal = new SimpleGoal(simpleGoal.Type, simpleGoal.Name, simpleGoal.Description,simpleGoal.Points,simpleGoal.IsComplete);
                        goalObjectsList.Add(goal);
                        currentGoalsAdded.Add(goal.SaveGoal());
                        }
                        if (goalChoice == 2)
                        {
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.Type = "Eternal Goal";
                            eternalGoal.Name = eternalGoal.GetGoalName();
                            eternalGoal.Description = eternalGoal.GetGoalDescription();
                            eternalGoal.Points = eternalGoal.GetGoalPoints();
                            EternalGoal goal = new EternalGoal(eternalGoal.Type, eternalGoal.Name, eternalGoal.Description,eternalGoal.Points);
                            goalObjectsList.Add(goal);
                            currentGoalsAdded.Add(goal.SaveGoal());
                        }
                        if (goalChoice == 3)
                        {
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.Type = "Checklist Goal";
                            checklistGoal.Name = checklistGoal.GetGoalName();
                            checklistGoal.Description = checklistGoal.GetGoalDescription();
                            checklistGoal.Points = checklistGoal.GetGoalPoints();
                            ChecklistGoal goal = new ChecklistGoal(checklistGoal.Type, checklistGoal.Name, checklistGoal.Description,checklistGoal.Points,checklistGoal.Bonus,checklistGoal.GoalAmount,checklistGoal.CurrentAmount);
                            goalObjectsList.Add(goal);
                            currentGoalsAdded.Add(goal.SaveGoal());
                        }
                        break;
                }
                while(goalChoice !>= 4);
            }
            if (userInput == 2)
            {
                ListGoals();
            }
            if (userInput == 3)
            {
                SaveGoals();
            }
            if (userInput == 4)
            {
                LoadGoals();
            }
            if (userInput == 5)
            {
                RecordGoals();
            }
            if (userInput == 6)
            {
                break;
            }
        }
        while(userInput != 6);
        Console.WriteLine("Hope to see you again soon!");
    }

    static void DisplayPoints()
    {
        CenterString($"Points earned: {points}");
    }
    static void CenterString(string words)
    {
        int wordLength = words.Length / 2;
        int position = menuWidth / 2 - wordLength;
        string spaces = new string(' ', position);
        Console.WriteLine(spaces + words);
    }
    static void PrettifyLines(string line)
    {
        string prettyLines = new string('-', menuWidth);
        if (line == newLine)
        {
            Console.WriteLine("\n" + prettyLines);
        }
        else if (line == endLine)
        {
            Console.WriteLine(prettyLines +"\n");
        }
        else
        {
            Console.WriteLine(prettyLines);
        }
    }

    static void LoadGoals()
    {
        currentGoalsAdded.Clear();
        string fileName = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines.Skip(1))
        {
            currentGoalsAdded.Add(line);
        }
    }

    static void ListGoals()
    {
        int counter = 1;

        foreach (string goal in currentGoalsAdded)
        {
            char completed = ' ';
            string[] goalWords = goal.Split('|');

            if (goalWords.Length == 5)
            {
                Console.WriteLine($"{counter}. [ ] {goalWords[0]}: {goalWords[1]} ({goalWords[2]})");
                counter ++;
            }
            else if (goalWords.Length == 6)
            {
                if (goalWords[4] == "true")
                {
                    completed = 'X';
                }
                Console.WriteLine($"{counter}. [{completed}] {goalWords[0]}: {goalWords[1]} ({goalWords[2]}) -- Currently completed: {goalWords[6]}/{goalWords[5]}");
                counter ++;
            }
        }
    }

    static void SaveGoals()
    {
        Console.WriteLine("Enter the filename for the goal file: ");
        string fileName = Console.ReadLine();

        bool isEmptyFile = false;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (lines.Length == 0)
        {
            isEmptyFile = true;
        }
        if (isEmptyFile == false)
        {
            using(StreamWriter outputfile = File.AppendText(fileName))
            {
                foreach (string goal in currentGoalsAdded)
                {
                    outputfile.WriteLine(goal);
                }
            }
        }
        else
        {
            using(StreamWriter outputfile = File.AppendText(fileName))
            {
                outputfile.WriteLine(points);
                foreach ( string goal in currentGoalsAdded)
                {
                    outputfile.WriteLine(goal);
                }
            }
        }
        currentGoalsAdded.Clear();
    }

    static void RecordGoals()
    {
        LoadGoals();
        ListGoals();
        Console.WriteLine("Which goal did you accomplish? ");
        string accomplish = Console.ReadLine();
        int accomplishedGoal = Int32.Parse(accomplish);

        foreach (string goal in currentGoalsAdded)
        {
            if (currentGoalsAdded.IndexOf(goal) == accomplishedGoal - 1)
            {
                string[] goalWords = goal.Split('|');
                int pointsNum = Int32.Parse(goalWords[3]);
                points += pointsNum;

                Console.WriteLine($"Congratulations! You have earned {pointsNum} points.");
            }
        }
    }
}