using System;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create a list of employees
        List<Employee> employees = new List<Employee>();

        // add some employees to the list
        employees.Add(new Employee
        {
            Name = "John Smith",
            HireDate = new DateTime(2019, 1, 1),
            LeaveBalance = 20
        });

        employees.Add(new Employee
        {
            Name = "Jane Doe",
            HireDate = new DateTime(2020, 2, 1),
            LeaveBalance = 15
        });

        // loop through the list of employees and output their names and leave days
        foreach (Employee employee in employees)
        {

            int leaveDays = employee.CalculateAmountOfLeaveDays();
            Console.WriteLine("{0}: {1} leave days", employee.Name, leaveDays);
        }

        Console.ReadLine();
    }
}

