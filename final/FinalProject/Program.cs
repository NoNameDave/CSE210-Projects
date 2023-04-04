using System;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
{
    int userInput = 0;
    do
    {
        userInput = GetMenuOption();
        if (userInput == 1)
        {           
            Employee employee = new Employee();
            employee.addEmployees();
            employee.SaveToFile(employee._fileName);
        }
        if (userInput == 2)
        {
            CalculateLeaveDays leave = new CalculateLeaveDays();
            List<string> leaveBalances = leave.CalculateAmountOfLeaveDays();
            foreach (string balance in leaveBalances)
            {
                Console.WriteLine(balance);
            }
        }
        if (userInput == 3)
        {
            LeaveTaken takeLeave = new LeaveTaken();
            Console.WriteLine("How many leave days would you like to apply for? ");
            string applyForLeave = Console.ReadLine();
            int leaveAmount = int.Parse(applyForLeave);
            takeLeave.TakeLeave(leaveAmount);
        }
    }
    while(userInput != 4);
    Console.WriteLine("Hope to see you again soon!");
}

    static int GetMenuOption()
    {
        Console.WriteLine("1. Add an Employee. ");
        Console.WriteLine("2. See Leave Availability. ");
        Console.WriteLine("3. Apply for Leave. ");
        Console.WriteLine("4. Quit");
        Console.Write("Select a number from the menu to begin the activity: ");
        string userInput = Console.ReadLine();
        int input = int.Parse(userInput);
        return input;
    }
}

