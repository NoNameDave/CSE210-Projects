using System;

class Program
{
    static void Main(string[] args)
    {
        static int GetMenuOption()
        {
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start lisning activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string userInput = Console.ReadLine();
        int input = int.Parse(userInput);
        return input;
        }
        
        int userInput = 0;
        do
        {
            userInput = GetMenuOption();
            if (userInput == 1)
            {           
                breathingActivity breathing = new breathingActivity();
                breathing.SetParagraph("This is the breathing activity."); 
                breathing.breathing();
            }
            if (userInput == 2)
            {
                reflectingActivit reflecting = new reflectingActivit();
                reflecting.SetParagraph("This is the reflecting activity.");
                reflecting.PickRandomThought();
                reflecting.DisplayPrompt();
            }
            if (userInput == 3)
            {
                listingActivity listing = new listingActivity();
                listing.SetParagraph("This is the listing activity.");
                listing.PickRandomThought();
                listing.List();
            }
        }
        while(userInput != 4);
        Console.WriteLine("Hope to see you again soon!");
    }
}