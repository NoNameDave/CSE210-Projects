public class breathingActivity: Activities
{
    public void breathing()
    {
        Activities activity = new Activities();
        Console.WriteLine("Please be patient while the activity loads.");
        activity.Animation(5,1000);
        Console.WriteLine("Thank you for your patience.");
        activity.GetParagraph();
        Thread.Sleep(3000);
        int counter = 0;
        while (counter < 3)
        {
        Console.WriteLine("Breathe in: ");
        activity.Timer(6,1000);
        Console.WriteLine("Breathe out: ");
        activity.Timer(6,1000);
        counter ++;
        }
        Console.WriteLine("Thank you for participating in this activity");
        Thread.Sleep(2000);
        Console.Clear();
    }
}