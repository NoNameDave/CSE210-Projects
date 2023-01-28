using System;

class Program
{
        static void Main(string[] args)
    {
        static int GetMenuOption()
        {
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Save");
        Console.WriteLine("4: Load");
        Console.WriteLine("5: Quit");
        Console.WriteLine("What would you like to do? ");
        string choice = Console.ReadLine();
        int input = int.Parse(choice);
        return input;
        }

        Console.WriteLine("Welcome to my Journal Program!");
        Write write = new Write();
        Display display = new Display();
        int input = 0;

    do
    {
        input = GetMenuOption();
        

        if (input == 1)
        {
            write.ToString();
        }
        else if (input == 2)
        {
            display.ToString();
        }
        else if (input == 3)
        {

        }
    }
    while (input != 5);
         
    }
}