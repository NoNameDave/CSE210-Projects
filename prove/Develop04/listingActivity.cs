public class listingActivity : Activities
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
    }

    public void List()
    {
        Console.WriteLine("Write as many items as you want, and when you are done just type QUIT to return to activity list. ");
        string input = Console.ReadLine();
        while(input != "QUIT")
        {
            if (input != "QUIT")
            {
                string list = Console.ReadLine();
                if (list == "QUIT")
                {
                    break;
                }
            }
            else
            break;
            
        }
    }
}