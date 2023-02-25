public  class reflectingActivit: Activities
{
    public void PickRandomThought()
    {
        Activities activity = new Activities();
        Console.WriteLine("Please be patient while the activity loads.");
        activity.Animation(5,1000);
        Console.WriteLine("Thank you for your patience.");
        Console.WriteLine();
        List<string> thoughts = new List<string>{"Did you have any experience worth sharing today?", "Think of one thing that made you happy throughout the day.", "What emotion are you currently feeling?"};
        var random = new Random();
        int index = random.Next(thoughts.Count);
        Console.WriteLine((thoughts[index]));
        activity.Animation(5,1000);
    }

    public void DisplayPrompt()
    {
        Activities activity = new Activities();
        Console.WriteLine();
        Console.WriteLine("Think about how this has influenced you throughout the day.");
        activity.Animation(15,1000);
        Console.WriteLine();
        Console.WriteLine("Hopefully this activity has made a difference.");
        Thread.Sleep(3000);
    }
}