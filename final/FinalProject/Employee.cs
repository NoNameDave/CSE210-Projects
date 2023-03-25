public class Employee : CalculateLeaveDays
{
    public string Name { get; set; }
    public DateTime HireDate { get; set; }
    public int LeaveBalance { get; set; }

    public void employees()
    {
        Employee employee = new Employee
            {
                Name = "John Smith",
                HireDate = new DateTime(2019, 1, 1),
                LeaveBalance = 20
            };

        int leaveDays = employee.CalculateAmountOfLeaveDays();
        Console.WriteLine("Employee {0} is entitled to {1} leave days", employee.Name, leaveDays);
    }         

}