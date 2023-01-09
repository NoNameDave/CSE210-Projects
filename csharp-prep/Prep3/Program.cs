using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "yes";

        Console.Write("Do you wish to play a game? ");
        input = Console.ReadLine();

        while (input == "yes")
        {
            Console.Write("What is the magic number? ");
            string num_input = Console.ReadLine();
            Console.WriteLine($"You guessed {num_input}");

            int number = int.Parse(num_input);

            if (number == 7) 
            {
                Console.WriteLine("You guessed it!");
            }
            else if (number > 7)
            {
                Console.WriteLine("Guess lower");
            }
            else 
            {
                Console.WriteLine("Guess Higher");
            }
        }

    }
}