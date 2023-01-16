using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        string name = "";

        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string num_input = Console.ReadLine();

        int number = int.Parse(num_input);

    }
}