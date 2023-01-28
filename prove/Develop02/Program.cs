using System;

class Program
{
        static void Main(string[] args)
    {
        Journal journal = new Journal();
        static int GetMenuOption()
        {
        
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Save");
        Console.WriteLine("4: Load");
        Console.WriteLine("5: Quit");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
        int input = int.Parse(choice);
        return input;
        }

        Console.WriteLine("Welcome to my Journal Program!");

        int input = 0;

    do
    {
        input = GetMenuOption();
        

        if (input == 1)
        {
            journal.AddEntry();
        }
        else if (input == 2)
        {
            journal.DisplayEntries();
        }
        else if (input == 3)
        {
            journal.SaveEntries();
        }
        else if (input == 4)
        {
            journal.LoadFile();
        }
    }
    while (input != 5);
         
    }
}