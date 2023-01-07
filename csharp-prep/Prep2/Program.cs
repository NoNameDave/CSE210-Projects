using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage marks did you get on your exam? ");
        string value = Console.ReadLine();

        int i = int.Parse(value);

        if(i >= 90) 
        {
            Console.WriteLine("You have a grade average of A.");
        }
        else if(i < 90 && i >= 80) 
        {
            Console.WriteLine("You have a grade average of B.");
        }
        else if(i < 80 && i >= 70) 
        {
            Console.WriteLine("You have a grade average of C.");
        }
        else if(i < 70 && i >= 60) {
            Console.WriteLine("You have a grade average of D.");
        }
        else
        {
            Console.WriteLine("You have a grade average of F.");
        }
        
    }
}